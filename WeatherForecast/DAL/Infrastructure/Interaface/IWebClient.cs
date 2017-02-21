using System.Threading.Tasks;

namespace DAL.Infrastructure.Interaface
{
    public interface IWebClient
    {
        Task<string> GetResponseAsync(string uri);
    }
}