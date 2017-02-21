using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.FiveDayForecast
{
    public class Location
    {
        [XmlElement(ElementName = DefaultXMLNames.Location)]
        public Coordinate Coordinates { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Name)]
        public string City { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Country)]
        public string Country { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Timezone)]
        public object Timezone { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Type)]
        public object Type { get; set; }

        private static class DefaultXMLNames
        {
            public const string Country = "country";

            public const string Location = "location";

            public const string Name = "name";

            public const string Timezone = "timezone";

            public const string Type = "type";
        }
    }
}