using System.Xml.Serialization;

namespace Core.Domain.FiveDayForecast
{
    public class Symbol
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Name)]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Number)]
        public int Number { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Var)]
        public string Var { get; set; }

        private static class DefaultXMLNames
        {
            public const string Name = "name";

            public const string Number = "number";

            public const string Var = "var";
        }
    }
}