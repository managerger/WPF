using System.Xml.Serialization;

namespace Core.Domain.CommonCharacteristics
{
    public class Coordinate
    {
        private int altitude;

        private string geobase;

        private int geobaseid;

        private double latitude;

        private double longitude;

        [XmlAttribute(DefaultXMLNames.Altitude)]
        public int Altitude
        {
            get { return this.altitude; }
            set { this.altitude = value; }
        }

        [XmlAttribute(DefaultXMLNames.Geobase)]
        public string Geobase
        {
            get { return this.geobase; }
            set { this.geobase = value; }
        }

        [XmlAttribute(DefaultXMLNames.GeobaseID)]
        public int Geobaseid
        {
            get { return this.geobaseid; }
            set { this.geobaseid = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Lat)]
        public double Latitude
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        [XmlAttribute(DefaultXMLNames.Latitude)]
        public double LatitudeForecast
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        [XmlAttribute(AttributeName = DefaultXMLNames.Lon)]
        public double Longitude
        {
            get { return this.longitude; }
            set { this.longitude = value; }
        }

        [XmlAttribute(DefaultXMLNames.Longitude)]
        public double LongitudeForecast
        {
            get { return this.longitude; }
            set { this.longitude = value; }
        }

        private static class DefaultXMLNames
        {
            public const string Altitude = "altitude";

            public const string Geobase = "geobase";

            public const string GeobaseID = "geobaseid";

            public const string Lat  = "lat";

            public const string Latitude = "latitude";

            public const string Lon = "lon";

            public const string Longitude = "longitude";
        }
    }
}