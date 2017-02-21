using System.IO;
using System.Xml.Serialization;
using DAL.Infrastructure.Interaface;
using Newtonsoft.Json;

namespace DAL.Infrastructure.Concrete
{
    public class Deserializer<T> : IDeserializer<T>
    {
        public T GetCurrentWeatherFromJSON(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public T GetTypeInstanceFromXML(string xml)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xml))
            {
                return (T)deserializer.Deserialize(reader);
            }
        }
    }
}