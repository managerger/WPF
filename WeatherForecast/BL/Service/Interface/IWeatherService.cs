using System.Threading.Tasks;

namespace BL.Service.Interface
{
    public interface IWeatherService<T>
    {
        Task<T> GetWeatherAsync(string cityName);
    }
}