using System;
using System.Xml.Serialization;

namespace Core.Domain.CurrentWeather
{
    public class LastUpdate
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Value)]
        public DateTime Value { get; set; }

        private static class DefaultXMLNames
        {
            public const string Value = "value";
        }
    }
}