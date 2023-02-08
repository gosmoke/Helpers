using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Integration
{
    public class HttpClientService : IHttpClientService
    {
        private readonly string _baseDomain;

        private const string APPLICATION_JSON = "application/json";
        private const string BEARER_SCHEME = "Bearer";
        private const string BASIC_SCHEME = "Basic";

        public HttpClientService(string baseDomain)
        {
            _baseDomain = baseDomain;
        }

        public async Task<HttpResponseMessage> LoginAsync(string encodedCredentials, string uri)
        {
            using (var client = CreateHttpClient(BASIC_SCHEME, encodedCredentials))
                return await client.PostAsync(uri, null);
        }

        public async Task<HttpResponseMessage> GetAsync(string uri, string apiToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> GetAsync(string uri, string apiToken, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.GetAsync(uri, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync(string uri, string apiToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PostAsync(uri, null);
        }

        public async Task<HttpResponseMessage> PostAsync(string uri, string apiToken, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PostAsync(uri, null, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string uri, string apiToken, T request)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PostAsJsonAsync(uri, request);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string uri, string apiToken, T request, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PostAsJsonAsync(uri, request, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(string uri, string apiToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PutAsync(uri, null);
        }

        public async Task<HttpResponseMessage> PutAsync(string uri, string apiToken, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PutAsync(uri, null, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string uri, string apiToken, T request)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PutAsJsonAsync(uri, request);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string uri, string apiToken, T request, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.PutAsJsonAsync(uri, request, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri, string apiToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.DeleteAsync(uri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri, string apiToken, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.DeleteAsync(uri, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync<T>(string uri, string apiToken, T request)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.DeleteAsJsonAsync(uri, request);
        }

        public async Task<HttpResponseMessage> DeleteAsync<T>(string uri, string apiToken, T request, CancellationToken cancellationToken)
        {
            using (var client = CreateHttpClient(BEARER_SCHEME, apiToken))
                return await client.DeleteAsJsonAsync(uri, request, cancellationToken);
        }

        private HttpClient CreateHttpClient(string authorizationScheme, string authorizationParameter)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(_baseDomain)
            };

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(APPLICATION_JSON));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(authorizationScheme, authorizationParameter);

            return client;
        }
    }
}
