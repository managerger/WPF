using System.Xml.Serialization;
using Core.Domain.CommonCharacteristics;

namespace Core.Domain.FiveDayForecast
{
    [XmlRoot(ElementName = DefaultXMLNames.Weatherdata)]
    public class FiveDayForecast
    {
        [XmlArray(ElementName = DefaultXMLNames.Forecast)]
        [XmlArrayItem(ElementName = DefaultXMLNames.Time, IsNullable = false)]
        public ThreeHourForecast[] ThreeHourForecasts { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Location)]
        public Location Location { get; set; }

        [XmlElement(ElementName = DefaultXMLNames.Sun)]
        public Sun Sun { get; set; }

        private static class DefaultXMLNames
        {
            public const string Forecast = "forecast";

            public const string Location = "location";

            public const string Sun = "sun";

            public const string Time = "time";
            
            public const string Weatherdata = "weatherdata";
        }
    }
}