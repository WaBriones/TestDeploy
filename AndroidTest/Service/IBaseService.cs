using System.Threading.Tasks;
using RestSharp;
namespace AndroidTest.Service
{
    public interface IBaseService
    {
        string BaseUrl { get; set; }
        Task<T> ExecuteAsync<T>(RestRequest baseUrl) where T : new();
    }
}