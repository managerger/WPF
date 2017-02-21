using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class WindSpeed
    {
        private string name;

        private double value;

        [XmlAttribute(AttributeName = DefaultXMLNames.Name)]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Mps)]
        public double ValueForecast
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private static class DefaultXMLNames
        {
            public const string Mps = "mps";

            public const string Name = "name";

            public const string Value = "value";
        }
    }
}