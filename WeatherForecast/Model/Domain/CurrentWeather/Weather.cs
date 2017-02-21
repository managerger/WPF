using System.Xml.Serialization;

namespace Core.Domain.CurrentWeather
{
    public class Weather
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Icon)]
        public string Icon { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Number)]
        public int Number { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public string Value { get; set; }

        private static class DefaultXMLNames
        {
            public const string Icon = "icon";

            public const string Number = "number";

            public const string Value = "value";
        }
    }
}