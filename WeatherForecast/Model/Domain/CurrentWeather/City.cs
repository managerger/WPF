using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.CurrentWeather
{
    public class City
    {
        [XmlElement(ElementName = DefaultXMLNames.Coord)]
        public Coordinate Coordinates { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Country)]
        public string Country { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.ID)]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Name)]
        public string Name { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Sun)]
        public Sun Sun { get; set; }

        private static class DefaultXMLNames
        {
            public const string Coord = "coord";

            public const string Country = "country";

            public const string ID = "id";

            public const string Name = "name";

            public const string Sun = "sun";
        }
    }
}