using System;
using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.FiveDayForecast
{
    public class ThreeHourForecast
    {
        [XmlElement(ElementName = DefaultXMLNames.Clouds)]
        public Clouds Clouds { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.From)]
        public DateTime From { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Humidity)]
        public Humidity Humidity { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Precipitation)]
        public Precipitation Precipitation { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Pressure)]
        public Pressure Pressure { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Symbol)]
        public Symbol Symbol { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Temperature)]
        public Temperature Temperature { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.To)]
        public DateTime To { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.WindDirection)]
        public WindDirection WindDirection { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.WindSpeed)]
        public WindSpeed WindSpeed { get; set; }

        private static class DefaultXMLNames
        {
            public const string Clouds = "clouds";

            public const string From = "from";

            public const string Humidity = "humidity";

            public const string Precipitation = "precipitation";

            public const string Pressure = "pressure";

            public const string Symbol = "symbol";

            public const string Temperature = "temperature";

            public const string To = "to";

            public const string WindDirection = "windDirection";

            public const string WindSpeed = "windSpeed";
        }
    }
}