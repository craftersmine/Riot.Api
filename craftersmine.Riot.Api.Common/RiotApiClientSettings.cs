using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public class RiotApiClientSettings
    {
        public string ApiKey { get; set; }
        public bool UseTournamentStub { get; set; }
    }

    public static class RiotApiClientSettingsExtensions
    {
    }

    public class RiotApiClientSettingsBuilder
    {
        internal RiotApiClientSettings Settings { get; }

        public RiotApiClientSettingsBuilder() => Settings = new RiotApiClientSettings();

        public RiotApiClientSettings Build()
        {
            if (string.IsNullOrWhiteSpace(Settings.ApiKey))
                throw new ArgumentNullException(nameof(Settings.ApiKey), "Riot API key cannot be empty or null!");

            return Settings;
        }

        public RiotApiClientSettingsBuilder UseApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "Riot API key cannot be empty or null!");

            Settings.ApiKey = apiKey;
            return this;
        }

        public RiotApiClientSettingsBuilder UseTournamentStub()
        {
            Settings.UseTournamentStub = true;
            return this;
        }
    }
}
