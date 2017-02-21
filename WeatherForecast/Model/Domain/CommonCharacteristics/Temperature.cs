using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class Temperature
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Max)]
        public double Max { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Min)]
        public double Min { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Unit)]
        public string Unit { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public double Value { get; set; }

        private static class DefaultXMLNames
        {
            public const string Max  = "max";

            public const string Min = "min";

            public const string Unit = "unit";

            public const string Value = "value";
        }
    }
}