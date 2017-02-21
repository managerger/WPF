using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class Humidity
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Unit)]
        public string Unit { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public double Value { get; set; }

        private static class DefaultXMLNames
        {
            public const string Unit = "unit";

            public const string Value = "value";
        }
    }
}