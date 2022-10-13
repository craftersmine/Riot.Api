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

        public void SetHeader(string header, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(header, value);
        }

        public async Task<T> Get<T>(string address, IDictionary<string, object> queryParams)
        {
            string queryParamsString = string.Empty;
            if (queryParamsString.Any())
            {
                foreach (var kvp in queryParams)
                {
                    queryParamsString = string.Join("&", string.Join("=", kvp.Key, kvp.Value));
                }

                queryParamsString = Uri.EscapeUriString(queryParamsString);
                address = string.Join("?", address, queryParamsString);
            }

            var response = await _httpClient.GetAsync(address);
            var responseStr = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                if (string.IsNullOrWhiteSpace(responseStr))
                    throw new RiotApiException(response.StatusCode);

                var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
                throw new RiotApiException(errRespObj);
            }

            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        public async Task<T> Post<T>(string address, IDictionary<string, object> queryParams, object bodyContent)
        {
            string queryParamsString = string.Empty;
            if (queryParamsString.Any())
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
            var responseStr = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                if (string.IsNullOrWhiteSpace(responseStr))
                    throw new RiotApiException(response.StatusCode);

                var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
                throw new RiotApiException(errRespObj);
            }

            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        public async Task<T> Put<T>(string address, IDictionary<string, object> queryParams, object bodyContent)
        {
            string queryParamsString = string.Empty;
            if (queryParamsString.Any())
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
            var responseStr = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                if (string.IsNullOrWhiteSpace(responseStr))
                    throw new RiotApiException(response.StatusCode);

                var errRespObj = JsonConvert.DeserializeObject<ErrorResponse>(responseStr);
                throw new RiotApiException(errRespObj);
            }

            return JsonConvert.DeserializeObject<T>(responseStr);
        }
    }
}
