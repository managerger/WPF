using System.IO;
using System.Net;
using System.Threading.Tasks;
using DAL.Infrastructure.Interaface;

namespace DAL.Infrastructure.Concrete
{
    public class WebClient : IWebClient
    {
        public async Task<string> GetResponseAsync(string uri)
        {
            WebRequest webRequest = WebRequest.Create(uri);
            using (WebResponse response = await webRequest.GetResponseAsync())
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                string responseData = await streamReader.ReadToEndAsync();
                return responseData;
            }
        }
    }
}