using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a base Riot API client class
    /// </summary>
    public class RiotApiClient
    {
        private Client _client;
        private RiotApiClientSettings _settings;

        /// <summary>
        /// Gets current HTTP client with corresponding Riot API key
        /// </summary>
        protected Client Client => _client;
        /// <summary>
        /// Gets current Riot API client settings used on creation
        /// </summary>
        protected RiotApiClientSettings Settings => _settings;

        /// <summary>
        /// Gets <see langword="true"/> if you reached rate-limit from Riot API servers
        /// </summary>
        public bool IsRateLimited => !(_client.GetRetryAfterTimeSpan() is null);
        /// <summary>
        /// Gets <see cref="TimeSpan"/> from last request to wait until next request can be made, or <see langword="null"/> if you are not currently rate-limited
        /// </summary>
        public TimeSpan? RetryAfter => _client.GetRetryAfterTimeSpan();
        /// <summary>
        /// Gets current Riot API key used by this instance
        /// </summary>
        public string ApiKey => Settings.ApiKey;

        /// <summary>
        /// Creates new instance of <see cref="RiotApiClient"/> to perform API calls
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotApiClient"/></param>
        public RiotApiClient(RiotApiClientSettings settings)
        {
            _client = new Client();
            _settings = settings;

            _client.SetHeader("X-Riot-Token", _settings.ApiKey);
        }
    }
}
