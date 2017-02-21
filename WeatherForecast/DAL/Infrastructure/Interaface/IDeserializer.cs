namespace DAL.Infrastructure.Interaface
{
    public interface IDeserializer<T>
    {
        T GetCurrentWeatherFromJSON(string json);

        T GetTypeInstanceFromXML(string xml);
    }
}