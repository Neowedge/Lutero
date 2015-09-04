using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Neowedge.Lutero
{
    public partial class Localization
    {
        const string FILES_ROOT = "Language";
        const string FILES_EXTENSION = "lang";

        public static Localization GetLocalization(string localizationCode)
        {
            FileStream file = null;
            System.Xml.Serialization.XmlSerializer serializer;
            try
            {
                file = new FileStream(Path.Combine(FILES_ROOT, String.Format("{0}.{1}", localizationCode, FILES_EXTENSION)),
                    FileMode.Open);
                serializer = new System.Xml.Serialization.XmlSerializer(typeof(Localization));
                return (Localization)serializer.Deserialize(file);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        public static List<LocalizationInfo> GetLocalizationList()
        {
            List<LocalizationInfo> localizationList = new List<LocalizationInfo>();

            DirectoryInfo directory = new DirectoryInfo(FILES_ROOT);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                if (file.Extension == FILES_EXTENSION)
                {
                    Localization localization = Localization.GetLocalization(Path.GetFileNameWithoutExtension(file.Name));
                    localizationList.Add(localization.Info);
                }
            }

            return localizationList;
        }
    }
}
