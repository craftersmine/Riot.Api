using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Exceptions;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a HTTP client basic functionality specifically for Riot API. This class cannot be inherited
    /// </summary>
    public sealed class Client
    {
        private readonly HttpClient _httpClient;
        private TimeSpan? _retryAfterLast;

        /// <summary>
        /// Gets current API base address
        /// </summary>
        public string BaseAddress
        {
            //get => _httpClient.BaseAddress.ToString();
            //set => _httpClient.BaseAddress = new Uri(value);
            get;
            set;
        }
        
        /// <summary>
        /// Creates a new instance of <see cref="Client"/> to make HTTP requests
        /// </summary>
        public Client()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Creates a new instance of <see cref="Client"/> to make HTTP requests
        /// </summary>
        /// <param name="baseAddress">API request base address</param>
        internal Client(string baseAddress) : base()
        {
            //_httpClient.BaseAddress = new Uri(baseAddress);
        }

        /// <summary>
        /// Sets a HTTP request header for all requests
        /// </summary>
        /// <param name="header">Header key</param>
        /// <param name="value">Header value</param>
        public void SetHeader(string header, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(header, value);
        }

        /// <summary>
        /// Gets time span from last failed request from <see cref="HttpResponseCode.RateLimitExceeded"/>
        /// </summary>
        /// <returns></returns>
        public TimeSpan? GetRetryAfterTimeSpan()
        {
            return _retryAfterLast;
        }

        /// <summary>
        /// Makes a GET request to specified address and query parameters and returns object as <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Object type to which convert a response</typeparam>
        /// <param name="address">Endpoint address for GET API request</param>
        /// <param name="queryParams">Additional query parameters (<see langword="null"/> for none)</param>
        /// <returns>Object of type <see cref="T"/> from response</returns>
        /// <exception cref="RiotApiException"></exception>
        public async Task<T> Get<T>(string address, IDictionary<string, object> queryParams)
        {
            string queryParamsString = string.Empty;
            if (!(queryParams is null) && queryParams.Any())
            {
                foreach (var kvp in queryParams)
                {
                    queryParamsString = string.Join("&", string.Join("=", kvp.Key, kvp.Value));
                }

                queryParamsString = Uri.EscapeUriString(queryParamsString);
                address = string.Join("?", address, queryParamsString);
            }

            var response = await _httpClient.GetAsync(address);

            if (!(response.Headers.RetryAfter is null))
                _retryAfterLast = response.Headers.RetryAfter.Delta;

            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode) return JsonConvert.DeserializeObject<T>(responseStr);
            if (string.IsNullOrWhiteSpace(responseStr))
                throw new RiotApiException((HttpResponseCode)response.StatusCode);

            var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
            throw new RiotApiException(errRespObj);

        }
        
        /// <summary>
        /// Makes a POST request to specified address, query parameters and body content as JSON and returns object as <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Object type to which convert a response</typeparam>
        /// <param name="address">Endpoint address for POST API request</param>
        /// <param name="queryParams">Additional query parameters (<see langword="null"/> for none)</param>
        /// <param name="bodyContent">POST request body parameters to send, will be converted to JSON</param>
        /// <returns>Object of type <see cref="T"/> from response</returns>
        /// <exception cref="RiotApiException"></exception>
        public async Task<T> Post<T>(string address, IDictionary<string, object> queryParams, object bodyContent)
        {
            string queryParamsString = string.Empty;
            if (!(queryParams is null) && queryParams.Any())
            {
                foreach (var kvp in queryParams)
                {
                    queryParamsString = string.Join("&", string.Join("=", kvp.Key, kvp.Value));
                }

                queryParamsString = Uri.EscapeUriString(queryParamsString);
                address = string.Join("?", address, queryParamsString);
            }

            string body = JsonConvert.SerializeObject(bodyContent);

            var response = await _httpClient.PostAsync(address, new StringContent(body));
            
            if (!(response.Headers.RetryAfter is null))
                _retryAfterLast = response.Headers.RetryAfter.Delta;

            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode) return JsonConvert.DeserializeObject<T>(responseStr);
            if (string.IsNullOrWhiteSpace(responseStr))
                throw new RiotApiException((HttpResponseCode)response.StatusCode);

            var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
            throw new RiotApiException(errRespObj);

        }
        
        /// <summary>
        /// Makes a PUT request to specified address, query parameters and body content as JSON and returns object as <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Object type to which convert a response</typeparam>
        /// <param name="address">Endpoint address for PUT API request</param>
        /// <param name="queryParams">Additional query parameters (<see langword="null"/> for none)</param>
        /// <param name="bodyContent">POST request body parameters to send, will be converted to JSON</param>
        /// <returns>Object of type <see cref="T"/> from response</returns>
        /// <exception cref="RiotApiException"></exception>
        public async Task<T> Put<T>(string address, IDictionary<string, object> queryParams, object bodyContent)
        {
            string queryParamsString = string.Empty;
            if (!(queryParams is null) && queryParams.Any())
            {
                foreach (var kvp in queryParams)
                {
                    queryParamsString = string.Join("&", string.Join("=", kvp.Key, kvp.Value));
                }

                queryParamsString = Uri.EscapeUriString(queryParamsString);
                address = string.Join("?", address, queryParamsString);
            }

            string body = JsonConvert.SerializeObject(bodyContent);

            var response = await _httpClient.PutAsync(address, new StringContent(body));
            
            if (!(response.Headers.RetryAfter is null))
                _retryAfterLast = response.Headers.RetryAfter.Delta;

            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode) return JsonConvert.DeserializeObject<T>(responseStr);
            if (string.IsNullOrWhiteSpace(responseStr))
                throw new RiotApiException((HttpResponseCode)response.StatusCode);

            var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
            throw new RiotApiException(errRespObj);

        }
    }
}
