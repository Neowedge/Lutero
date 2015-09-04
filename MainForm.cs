using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Globalization;

namespace Neowedge.Lutero
{
    public partial class MainForm : Form
    {
        Dictionary<string, Localization> localizationList;
        bool loaded;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cbLenguaje.DataSource = CultureInfo.GetCultures(CultureTypes.SpecificCultures).OrderBy<CultureInfo, string>(cul => cul.DisplayName).ToArray<CultureInfo>();
            this.cbLenguaje.ValueMember = "Name";
            this.cbLenguaje.DisplayMember = "DisplayName";

            localizationList = new Dictionary<string, Localization>();
            loaded = true;

            if (!String.IsNullOrEmpty(Properties.Settings.Default.CurrentLangFolder))
            {
                this.LoadFiles();
            }
        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CurrentLangFolder = this.folderBrowserDialog.SelectedPath;
                LoadFiles();
                Properties.Settings.Default.Save();
            }
        }

        private void btConfiguracion_Click(object sender, EventArgs e)
        {
            ConfigurationForm configrationForm = new ConfigurationForm();
            if (configrationForm.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.Save();
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.chkOnTop.Checked;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SearchString();
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            ReloadAllResources();
        }

        private void btCodigo_Click(object sender, EventArgs e)
        {
            if (this.cbTags.SelectedItem != null)
                System.Windows.Forms.Clipboard.SetText(String.Format(Properties.Settings.Default.Accessor, this.cbTags.SelectedItem));
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Localization> localizationEntry in this.localizationList)
            {
                List<Resource> resourceList = localizationEntry.Value.ArrayOfResources.ToList<Resource>();

                resourceList.Remove(resourceList.Where<Resource>(res => res.Name == (string)this.cbTags.SelectedItem).First<Resource>());

                localizationEntry.Value.ArrayOfResources = resourceList.ToArray<Resource>();
            }
            this.cbTags.Items.Remove(this.cbTags.SelectedItem);
        }

        private void btNuevoLenguaje_Click(object sender, EventArgs e)
        {
            if (!CreateNewLanguage())
                MessageBox.Show("Ese lenguaje ya existe para esta versión");
        }

        private void cbTags_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.loaded)
                ChangeResource((string)this.cbTags.SelectedItem);
        }

        private void cbTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.loaded && (e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                ChangeResource(this.cbTags.Text);
                this.cbTags.SelectedItem = this.cbTags.Text;
            }
        }

        private void DataGridViewTextos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.loaded && (e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                this.DataGridViewTextos.CurrentCell.Value += "\n";
                e.Handled = true;
            }
        }

        private void DataGridViewTextos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (loaded)
            {
                this.localizationList[(string)this.DataGridViewTextos.Rows[e.RowIndex].Cells[0].Value].ArrayOfResources.
                    Where<Resource>(res => res.Name == (string)this.cbTags.SelectedItem).First<Resource>().Value =
                    this.DataGridViewTextos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                this.btGuardar.Enabled = true;
            }
        }

        private void btGeneraCodigo_Click(object sender, EventArgs e)
        {
            if (this.cbTags.Items.Count > 0)
                System.Windows.Forms.Clipboard.SetText(GenerateCode());
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void LoadFiles()
        {
            this.cbTags.Items.Clear();

            string[] fileNames = Directory.GetFiles(Properties.Settings.Default.CurrentLangFolder, "*.lng", SearchOption.TopDirectoryOnly);
            Array.Sort(fileNames);

            foreach (string fileName in fileNames)
            {
                Localization localization;
                FileStream file = null;
                System.Xml.Serialization.XmlSerializer serializer;
                try
                {
                    file = new FileStream(fileName, FileMode.Open);
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Localization));
                    localization = (Localization)serializer.Deserialize(file);

                    if (localization.ArrayOfResources != null)
                    {
                        localization.ArrayOfResources.OrderBy<Resource, string>(res => res.Name);

                        foreach (Resource resource in localization.ArrayOfResources)
                        {
                            if (!this.cbTags.Items.Contains(resource.Name))
                                this.cbTags.Items.Add(resource.Name);
                        }
                    }

                    if (!this.localizationList.ContainsKey(localization.Info.Language))
                        this.localizationList.Add(localization.Info.Language, localization);
                }
                finally
                {
                    if (file != null)
                        file.Close();
                }
            }
            this.GroupBoxTextos.Enabled = true;
        }


        private void SearchString()
        {
            this.cbTags.Items.Clear();
            foreach (KeyValuePair<string, Localization> localizationEntry in this.localizationList)
            {
                foreach (Resource resource in localizationEntry.Value.ArrayOfResources)
                {
                    if (!this.cbTags.Items.Contains(resource.Name) && resource.Type == "System.String")
                    {
                        if (String.IsNullOrEmpty(this.txBuscar.Text))
                        {
                            if (String.IsNullOrEmpty(resource.Name))
                                this.cbTags.Items.Add(resource.Name);
                        }
                        else
                        {
                            if (((string)resource.Value).Contains(this.txBuscar.Text))
                                this.cbTags.Items.Add(resource.Name);
                        }
                    }
                }
            }
        }

        private void ReloadAllResources()
        {
            foreach (KeyValuePair<string, Localization> localizationEntry in this.localizationList)
            {
                foreach (Resource resource in localizationEntry.Value.ArrayOfResources)
                {
                    if (!this.cbTags.Items.Contains(resource.Name))
                        this.cbTags.Items.Add(resource.Name);
                }
            }
        }

        private bool CreateNewLanguage()
        {
            FileStream file = null;
            System.Xml.Serialization.XmlSerializer serializer;
            try
            {
                CultureInfo language = ((CultureInfo)this.cbLenguaje.SelectedItem);
                string fileName = Path.Combine(Properties.Settings.Default.CurrentLangFolder, String.Format("{0}.lng", language.Name));
                if (File.Exists(fileName))
                    return false;

                file = new FileStream(fileName, FileMode.CreateNew);

                Localization localization = new Localization();
                localization.Info = new LocalizationInfo();
                localization.Info.Language = language.Name;
                localization.Info.EnglishName = language.EnglishName;
                localization.Info.NativeName = language.NativeName;

                serializer = new System.Xml.Serialization.XmlSerializer(typeof(Localization));
                serializer.Serialize(file, localization);

                file.Close();
                file = null;

                LoadFiles();

                if (!String.IsNullOrEmpty(this.cbTags.Text))
                    ChangeResource(this.cbTags.Text);

                return true;
            }
            catch (Exception ex)
            {
                if (file != null)
                    file.Close();
                return false;
            }
        }

        private void ChangeResource(string name)
        {
            this.DataGridViewTextos.Rows.Clear();

            foreach (KeyValuePair<string, Localization> localizationEntry in this.localizationList)
            {
                Resource resource = null;

                if (localizationEntry.Value.ArrayOfResources != null && localizationEntry.Value.ArrayOfResources.Where<Resource>(res => res.Name == name).Count<Resource>() > 0)
                    resource = localizationEntry.Value.ArrayOfResources.Where<Resource>(res => res.Name == name).First<Resource>();

                if (resource == null)
                {
                    List<Resource> resourceList;
                    if (localizationEntry.Value.ArrayOfResources != null)
                        resourceList = localizationEntry.Value.ArrayOfResources.ToList<Resource>();
                    else
                        resourceList = new List<Resource>();

                    resource = new Resource();
                    resource.Name = name;
                    resource.Type = "System.String";
                    resource.Value = String.Empty;

                    resourceList.Add(resource);

                    localizationEntry.Value.ArrayOfResources = resourceList.ToArray<Resource>();

                    this.btGuardar.Enabled = true;
                }

                if (!cbTags.Items.Contains(name))
                    cbTags.Items.Add(name);

                this.DataGridViewTextos.Rows.Add(new Object[] { localizationEntry.Key,
                    String.Format("{0} ({1})", localizationEntry.Value.Info.EnglishName, localizationEntry.Value.Info.Language),
                    resource.Value });
            }
        }

        private string GenerateCode()
        {
            StringBuilder code = new StringBuilder();
            string[] codeLines = new string[this.cbTags.Items.Count];
            
            Localization localization = null;
            foreach (KeyValuePair<string,Localization> localizationEntry in this.localizationList)
            {
                if (localizationEntry.Value.ArrayOfResources != null && localizationEntry.Value.ArrayOfResources.Length == codeLines.Length)
                {
                    localization = localizationEntry.Value;
                    break;
                }
            }
            if (localization == null)
                return String.Empty;

            System.Text.RegularExpressions.Regex regexp = new System.Text.RegularExpressions.Regex("{[^0-9]");
            string codePattern = regexp.Replace(Properties.Settings.Default.Code, "{{ ");

            regexp = new System.Text.RegularExpressions.Regex("[^0-9]}");
            codePattern = regexp.Replace(codePattern, " }}");

            for (int i = 0; i < codeLines.Length; i++)
            {
                Resource resource = localization.ArrayOfResources[i];
                codeLines[i] = String.Format(codePattern, resource.Name, resource.Type);
            }

            Array.Sort<string>(codeLines);

            foreach (string line in codeLines)
                code.AppendLine(line);

            return code.ToString();
        }

        private void Save()
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Localization));
                foreach (KeyValuePair<string, Localization> localizationEntry in this.localizationList)
                {
                    FileStream file = null;
                    string fileName = "Ninguno"; 
                    try
                    {
                        fileName = Path.Combine(Properties.Settings.Default.CurrentLangFolder, String.Format("{0}.{1}", localizationEntry.Key, "lng"));
                        file = new FileStream(fileName, FileMode.Create);

                        serializer.Serialize(file, localizationEntry.Value);
                    }
                    catch
                    {
                        MessageBox.Show(String.Format("No se ha podido guardar el archivo de lenguaje {0}.", fileName));
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }

                this.btGuardar.Enabled = false;
            }
        }
    }
}
