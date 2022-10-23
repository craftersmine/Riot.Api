using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Tournament.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends Tournament update parameters
    /// </summary>
    public class LeagueTournamentCodeUpdateParameters
    {
        /// <summary>
        /// Gets or sets allowed players by their summoners IDs to participate in tournament
        /// </summary>
        [JsonProperty("allowedSummonerIds")]
        public string[] AllowedSummonerIds { get; set; }
        /// <summary>
        /// Gets or sets desired champion pick type for tournament
        /// </summary>
        [JsonProperty("pickType"), JsonConverter(typeof(LeaguePickTypeConverter))]
        public LeaguePickType PickType { get; set; }
        /// <summary>
        /// Gets or sets desired League of Legends map for tournament
        /// </summary>
        [JsonProperty("mapType"), JsonConverter(typeof(LeagueMapTypeConverter))]
        public LeagueMapType MapType { get; set; }
        /// <summary>
        /// Gets or sets desired spectator type for tournament
        /// </summary>
        [JsonProperty("spectatorType"), JsonConverter(typeof(LeagueSpectatorTypeConverter))]
        public LeagueSpectatorType SpectatorType { get; set; }
    }
}
