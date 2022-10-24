using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Tournament.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends tournament code information
    /// </summary>
    public class LeagueTournamentCode
    {
        /// <summary>
        /// Gets a tournament teams size
        /// </summary>
        [JsonProperty("teamSize")]
        public int TeamSize { get; private set; }
        /// <summary>
        /// Gets a tournament provider ID
        /// </summary>
        [JsonProperty("providerId")]
        public int ProviderId { get; private set; }
        /// <summary>
        /// Gets a tournament ID
        /// </summary>
        [JsonProperty("tournamentId")]
        public int TournamentId { get; private set; }
        /// <summary>
        /// Gets a tournament code ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets a tournament code
        /// </summary>
        [JsonProperty("code")]
        public string TournamentCode { get; private set; }
        /// <summary>
        /// Gets a provider specified tournament metadata string
        /// </summary>
        [JsonProperty("metaData")]
        public string Metadata { get; private set; }
        /// <summary>
        /// Gets a tournament password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; private set; }
        /// <summary>
        /// Gets a tournament region
        /// </summary>
        [JsonProperty("region"), JsonConverter(typeof(RiotPlatformAsLeagueRegionConverter))]
        public RiotPlatform Region { get; private set; }
        /// <summary>
        /// Gets a tournament map type
        /// </summary>
        [JsonProperty("map"), JsonConverter(typeof(LeagueMapTypeConverter))]
        public LeagueMapType Map { get; private set; }
        /// <summary>
        /// Gets a tournament champion pick type
        /// </summary>
        [JsonProperty("pickType"), JsonConverter(typeof(LeaguePickTypeConverter))]
        public LeaguePickType PickType { get; private set; }
        /// <summary>
        /// Gets a tournament spectators type
        /// </summary>
        [JsonProperty("spectators"), JsonConverter(typeof(LeagueSpectatorTypeConverter))]
        public LeagueSpectatorType SpectatorType { get; private set; }
    }
}
