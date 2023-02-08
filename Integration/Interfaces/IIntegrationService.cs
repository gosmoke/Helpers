using System.Threading;
using System.Threading.Tasks;

namespace Integration
{
    public interface IIntegrationService
    {
        string Token { get; set; }

        Task<IResponse<AuthenticationResponse>> PostLoginAsync(string encryptedCredentials);

        Task<IResponse<T>> GetAsync<T>(string requestUrl);
        Task<IResponse<T>> GetAsync<T>(string requestUrl, CancellationToken cancellationToken);

        Task<IResponse<T>> PostAsync<T>(string requestUrl);
        Task<IResponse<T>> PostAsync<T>(string requestUrl, CancellationToken cancellationToken);
        Task<IResponse<T>> PostAsync<T>(string requestUrl, T request);
        Task<IResponse<T>> PostAsync<T>(string requestUrl, T request, CancellationToken cancellationToken);
        Task<IResponse<TResponse>> PostAsync<TRequest, TResponse>(string requestUrl, TRequest request);
        Task<IResponse<TResponse>> PostAsync<TRequest, TResponse>(string requestUrl, TRequest request, CancellationToken token);
        Task PostAsync(string requestUrl);
        Task PostAsync(string requestUrl, CancellationToken cancellationToken);

        Task<IResponse<T>> PutAsync<T>(string requestUrl);
        Task<IResponse<T>> PutAsync<T>(string requestUrl, CancellationToken cancellationToken);
        Task<IResponse<T>> PutAsync<T>(string requestUrl, T value);
        Task<IResponse<T>> PutAsync<T>(string requestUrl, T value, CancellationToken cancellationToken);
        Task<IResponse<TResponse>> PutAsync<TRequest, TResponse>(string requestUrl, TRequest request);
        Task<IResponse<TResponse>> PutAsync<TRequest, TResponse>(string requestUrl, TRequest request, CancellationToken cancellationToken);
        Task PutAsync(string requestUrl);
        Task PutAsync(string requestUrl, CancellationToken cancellationToken);

        Task<IResponse<T>> DeleteAsync<T>(string requestUrl);
        Task<IResponse<T>> DeleteAsync<T>(string requestUrl, CancellationToken cancellationToken);
        Task<IResponse<T>> DeleteAsync<T>(string requestUrl, T value);
        Task<IResponse<T>> DeleteAsync<T>(string requestUrl, T value, CancellationToken cancellationToken);
        Task<IResponse<TResponse>> DeleteAsync<TRequest, TResponse>(string requestUrl, TRequest value);
        Task<IResponse<TResponse>> DeleteAsync<TRequest, TResponse>(string requestUrl, TRequest value, CancellationToken cancellationToken);
        Task DeleteAsync(string requestUrl);
        Task DeleteAsync(string requestUrl, CancellationToken cancellationToken);
    }
}
