﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3053
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace Lutero
{

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/LocalizedResources.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/LocalizedResources.xsd", IsNullable = false)]
    public partial class Localization
    {

        private LocalizationInfo infoField;

        private Resource[] arrayOfResourcesField;

        /// <comentarios/>
        public LocalizationInfo Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("ArrayOfResources")]
        public Resource[] ArrayOfResources
        {
            get
            {
                return this.arrayOfResourcesField;
            }
            set
            {
                this.arrayOfResourcesField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/LocalizedResources.xsd")]
    public partial class LocalizationInfo
    {

        private string languageField;

        private string englishNameField;

        private string nativeNameField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "language")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <comentarios/>
        public string EnglishName
        {
            get
            {
                return this.englishNameField;
            }
            set
            {
                this.englishNameField = value;
            }
        }

        /// <comentarios/>
        public string NativeName
        {
            get
            {
                return this.nativeNameField;
            }
            set
            {
                this.nativeNameField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/LocalizedResources.xsd")]
    public partial class Resource
    {

        private string nameField;

        private string typeField;

        private object valueField;

        /// <comentarios/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <comentarios/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
