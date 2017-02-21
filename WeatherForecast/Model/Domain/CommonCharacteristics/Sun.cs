using System;
using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class Sun
    {
        [XmlAttribute(AttributeName = DefaultXMLNames.Rise)]
        public DateTime Rise { get; set; }

        [XmlAttribute(AttributeName = DefaultXMLNames.Set)]
        public DateTime Set { get; set; }

        private static class DefaultXMLNames
        {
            public const string Rise = "rise";

            public const string Set = "set";
        }
    }
}