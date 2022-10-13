using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents Riot API Client settings
    /// </summary>
    public class RiotApiClientSettings
    {
        /// <summary>
        /// Gets Riot API key
        /// </summary>
        public string ApiKey { get; internal set; }

        /// <summary>
        /// Gets <see langword="true"/> to use Riot Tournament Stub API instead of Riot Tournament API
        /// </summary>
        public bool UseTournamentStub { get; internal set; } = false;

        /// <summary>
        /// Use <see cref="RiotApiClientSettingsBuilder"/> instead
        /// </summary>
        internal RiotApiClientSettings() {}
    }

    /// <summary>
    /// Allows you to create <see cref="RiotApiClientSettings"/> using fluent API
    /// </summary>
    public sealed class RiotApiClientSettingsBuilder
    {
        internal RiotApiClientSettings Settings { get; }

        /// <summary>
        /// Gets current settings
        /// </summary>
        public RiotApiClientSettingsBuilder() => Settings = new RiotApiClientSettings();

        /// <summary>
        /// Returns built settings
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">If API key is not set (null or empty string)</exception>
        public RiotApiClientSettings Build()
        {
            if (string.IsNullOrWhiteSpace(Settings.ApiKey))
                throw new ArgumentNullException(nameof(Settings.ApiKey), "Riot API key cannot be empty or null!");

            return Settings;
        }

        /// <summary>
        /// Sets Riot API key
        /// </summary>
        /// <param name="apiKey">Riot API key of your application</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">If API keu is not set (null or empty string)</exception>
        public RiotApiClientSettingsBuilder UseApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "Riot API key cannot be empty or null!");

            Settings.ApiKey = apiKey;
            return this;
        }

        /// <summary>
        /// Switches Riot API client to use Tournament Stub API instead of Tournament API if used
        /// </summary>
        /// <returns></returns>
        public RiotApiClientSettingsBuilder UseTournamentStub()
        {
            Settings.UseTournamentStub = true;
            return this;
        }
    }
}
