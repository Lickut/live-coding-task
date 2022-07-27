using LiveCodingApi.Models;
using RestSharp;

namespace LiveCodingApi.Utils
{
    public class CatFactApiClient
    {
        private RestClient _client;

        public CatFactApiClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<BreedsResponse?> GetBreeds(int limit)
        {
            var request = new RestRequest("breeds", Method.Get)
                .AddQueryParameter("limit", limit);
            return await _client.GetAsync<BreedsResponse>(request);
        }
    }
}
