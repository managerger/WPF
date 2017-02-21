using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class Clouds
    {
        private int all;

        private string unit;

        private string value;


        [XmlAttribute(AttributeName = DefaultXMLNames.All)]
        public int All
        {
            get { return this.all; }
            set { this.all = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Name)]
        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Unit)]
        public string UnitForecast
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private static class DefaultXMLNames
        {
            public const string All = "all";

            public const string Name = "name";

            public const string Unit = "unit";

            public const string Value = "value";
        }
    }
}