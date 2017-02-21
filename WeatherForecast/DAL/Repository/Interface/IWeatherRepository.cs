using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IWeatherRepository<T>
    {
        Task<T> GetWeatherAsync(string cityName);
    }
}