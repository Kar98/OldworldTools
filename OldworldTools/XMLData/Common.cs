namespace OldworldTools.XMLData
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryPair
    {

        private string zIndexField;

        private short iValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public short iValue
        {
            get
            {
                return this.iValueField;
            }
            set
            {
                this.iValueField = value;
            }
        }
    }
}
