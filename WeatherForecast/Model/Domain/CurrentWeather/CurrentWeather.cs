using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.CurrentWeather
{
    [XmlRoot(ElementName = DefaultXMLNames.Current)]
    public class CurrentWeather
    {
        [XmlElement(ElementName = DefaultXMLNames.City)]
        public City City { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Clouds)]
        public Clouds Clouds { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Humidity)]
        public Humidity Humidity { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.LastUpdate)]
        public LastUpdate Lastupdate { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Precipitation)]
        public Precipitation Precipitation { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Pressure)]
        public Pressure Pressure { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Temperature)]
        public Temperature Temperature { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Weather)]
        public Weather Weather { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Wind)]
        public WindCharacteristics WindCharacteristics { get; set; }

        private static class DefaultXMLNames
        {
            public const string Current = "current";

            public const string City = "city";

            public const string Clouds = "clouds";

            public const string Humidity = "humidity";

            public const string LastUpdate = "lastupdate";

            public const string Precipitation = "precipitation";

            public const string Pressure = "pressure";

            public const string Temperature = "temperature";

            public const string Weather = "weather";

            public const string Wind = "wind";
        }
    }   
}