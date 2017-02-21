using System.Xml.Serialization;

namespace Core.Domain.CurrentWeather
{
    public class Precipitation
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Mode)]
        public string Mode { get; set; }

        private static class DefaultXMLNames
        {
            public const string Mode = "mode";
        }
    }
}