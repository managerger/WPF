using System.Xml.Serialization;

namespace Core.Domain.FiveDayForecast
{
    public class Precipitation
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Type)]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Unit)]
        public string Unit { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public double Value { get; set; }

        private static class DefaultXMLNames
        {
            public const string Type = "type";

            public const string Unit = "unit";

            public const string Value = "value";
        }
    }
}