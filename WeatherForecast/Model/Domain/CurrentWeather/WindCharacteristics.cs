using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.CurrentWeather
{
    public class WindCharacteristics
    {
        [XmlElement(ElementName = DefaultXMLNames.Direction)]
        public WindDirection Direction { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Gusts)]
        public string Gusts { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Speed)]
        public WindSpeed Speed { get; set; }

        private static class DefaultXMLNames
        {
            public const string Direction = "direction";

            public const string Gusts = "gusts";

            public const string Speed = "speed";
        }
    }
}