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
        /// Gets <see langword="true"/> to use experimental Ranked Leagues API. https://developer.riotgames.com/apis#league-exp-v4
        /// </summary>
        public bool UseExperimentalLeaguesApi { get; internal set; } = false;

        /// <summary>
        /// Gets default Riot Data Region for Account API requests
        /// </summary>
        /// <remarks>
        /// Default value is <see cref="RiotRegion.Europe"/>
        /// </remarks>
        public RiotRegion DefaultDataRegion { get; internal set; } = RiotRegion.Europe;

        /// <summary>
        /// Gets default Riot Data Shard for Valorant Content API requests
        /// </summary>
        /// <remarks>
        /// Default value is <see cref="RiotShards.Europe"/>
        /// </remarks>
        public RiotShards DefaultValorantContentShard { get; internal set; } = RiotShards.ValorantEurope;

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
        private RiotApiClientSettings Settings { get; }

        /// <summary>
        /// Gets current settings
        /// </summary>
        public RiotApiClientSettingsBuilder() => Settings = new RiotApiClientSettings();

        /// <summary>
        /// Creates a new empty instance of <see cref="RiotApiClientSettingsBuilder"/>
        /// </summary>
        /// <returns></returns>
        public static RiotApiClientSettingsBuilder CreateSettingsBuilder()
        {
            return new RiotApiClientSettingsBuilder();
        }

        /// <summary>
        /// Creates a new instance of <see cref="RiotApiClientSettingsBuilder"/> with specified Riot Games API key
        /// </summary>
        /// <param name="apiKey">Riot Games API key</param>
        /// <returns></returns>
        public static RiotApiClientSettingsBuilder CreateSettingsBuilder(string apiKey)
        {
            return new RiotApiClientSettingsBuilder().UseApiKey(apiKey);
        }

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
        /// Sets Riot Games API key
        /// </summary>
        /// <param name="apiKey">Riot API key of your application</param>
        /// <remarks>
        ///  You can obtain development key here: https://developer.riotgames.com <br/>
        ///  If you deploying an application for production you need to register your application to obtain permanent API key <br/>
        ///  You can register your application here: https://developer.riotgames.com/app-type
        /// </remarks>
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

        /// <summary>
        /// Sets default Riot Games Data Region for Account API requests. It is recommended by Riot to use a cluster near you (near application host)
        /// </summary>
        /// <param name="region">Riot Region</param>
        /// <returns></returns>
        public RiotApiClientSettingsBuilder UseDefaultDataRegion(RiotRegion region)
        {
            Settings.DefaultDataRegion = region;
            return this;
        }

        /// <summary>
        /// Enables using of League-EXP v4 API for some requests in League.SummonerLeagues API
        /// </summary>
        /// <returns></returns>
        public RiotApiClientSettingsBuilder UseExperimentalLeaguesApi()
        {
            Settings.UseExperimentalLeaguesApi = true;
            return this;
        }

        /// <summary>
        /// Sets default Valorant Data Shard for requests of Content API to be executed against. It is recommended by Riot to use a cluster near you (near application host)
        /// </summary>
        /// <param name="shard">Riot Valorant Data Shard</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When unknown or unsupported shard is selected (ex. Legends of Runeterra shard)</exception>
        public RiotApiClientSettingsBuilder UseDefaultValorantContentRegionShard(RiotShards shard)
        {
            if (shard == RiotShards.LoRAmericas || shard == RiotShards.LoRAsiaPacific ||
                shard == RiotShards.LoREurope || shard == RiotShards.Unknown)
                throw new ArgumentException("Unexpected value for shard: " + shard.GetShardString() + " - " + shard.ToString(), nameof(shard));

            Settings.DefaultValorantContentShard = shard;
            return this;
        }
    }
}
