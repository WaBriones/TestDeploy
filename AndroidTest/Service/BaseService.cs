using System;
using System.Threading.Tasks;
using RestSharp;

namespace AndroidTest.Service
{
    public class BaseService : IBaseService
    {
        public string BaseUrl { get; set; }

        public Task<T> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            var taskCompletionSource = new TaskCompletionSource<T>();

            client.ExecuteAsync<T>(request, (response) => taskCompletionSource.SetResult(response.Data));
            return taskCompletionSource.Task;
        }
    }
}