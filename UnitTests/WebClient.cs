using System;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using UnitTests.Models;

namespace UnitTests
{
	public class WebClient : IDisposable
	{
		public readonly RestClient _client;

		public WebClient()
		{
			_client = new RestClient("http://localhost:5030")
				.UseSerializer(() => new JsonNetSerializer());

			//var options = new RestClientOptions("http://localhost:5030")
			//{
			//	// for mitm proxy
			//	Proxy = new WebProxy("localhost", 8080) { BypassProxyOnLocal = false },
			//	Timeout = 1000
			//};
			//_client = new RestClient(options);
		}

		public void Dispose()
        {

        }

        public Task<Pizza> GetPizza(int id)
        //public Task<RestResponse<Pizza>> GetPizza(int id)
		{
			var request = new RestRequest($"api/pizza/{id}");
			return _client.GetAsync<Pizza>(request);
        }
    }
}

