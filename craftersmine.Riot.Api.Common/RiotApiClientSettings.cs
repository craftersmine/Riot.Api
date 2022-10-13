using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public partial class RiotApiClientSettings : IRiotApiClientSettings
    {
        public string ApiKey { get; set; }
    }

    public partial class RiotApiClientSettings
    {
        public bool UseTournamentStub { get; set; }
    }

    public static class RiotApiClientSettingsExtensions
    {
        public static RiotApiClientSettingsBuilder UseTournamentStub(this RiotApiClientSettingsBuilder settings)
        {
            ((RiotApiTournamentClientSettings)settings.Settings).UseTournamentStub = true;
            return settings;
        }

        public static RiotApiClientSettingsBuilder UseApiKey(this RiotApiClientSettingsBuilder settings,
            string apiKey)
        {
            settings.Settings.ApiKey = apiKey;
            return settings;
        }
    }

    public class RiotApiClientSettingsBuilder
    {
        internal IRiotApiClientSettings Settings { get; private set; }

        public RiotApiClientSettingsBuilder() => Settings = new RiotApiClientSettings();

        public IRiotApiClientSettings Build()
        {
            if (string.IsNullOrWhiteSpace(Settings.ApiKey))
                throw new ArgumentNullException(nameof(Settings.ApiKey), "Riot API key cannot be empty or null!");
            return Settings;
        }
    }
}
