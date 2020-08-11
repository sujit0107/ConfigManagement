using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigManagement
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class validations
    {

        private validationsOrderFileValidations orderFileValidationsField;

        private validationsError[] errorMessagesField;

        /// <remarks/>
        public validationsOrderFileValidations OrderFileValidations
        {
            get
            {
                return this.orderFileValidationsField;
            }
            set
            {
                this.orderFileValidationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Error", IsNullable = false)]
        public validationsError[] ErrorMessages
        {
            get
            {
                return this.errorMessagesField;
            }
            set
            {
                this.errorMessagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class validationsOrderFileValidations
    {

        private validationsOrderFileValidationsValidation[] validationField;

        private bool isEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Validation")]
        public validationsOrderFileValidationsValidation[] Validation
        {
            get
            {
                return this.validationField;
            }
            set
            {
                this.validationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class validationsOrderFileValidationsValidation
    {

        private string keyField;

        private bool isEnabledField;

        private string errorKeyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorKey
        {
            get
            {
                return this.errorKeyField;
            }
            set
            {
                this.errorKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class validationsError
    {

        private string keyField;

        private string errorMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }


}
