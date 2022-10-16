using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.SummonerLeagues.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents a specific Ranked league in League of Legends
    /// </summary>
    public class LeaguesList
    {
        /// <summary>
        /// Gets internal League GUID
        /// </summary> 
        [JsonProperty("leagueId")]
        public string? LeagueId { get; private set; }
        /// <summary>
        /// Gets internal League name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; private set; }
        /// <summary>
        /// Gets League tier
        /// </summary>
        [JsonProperty("tier"), JsonConverter(typeof(LeagueRankedTierConverter))]
        public LeagueRankedTier Tier { get; private set; }
        /// <summary>
        /// Gets League queue type
        /// </summary>
        [JsonProperty("queue"), JsonConverter(typeof(LeagueQueueTypeConverter))]
        public LeagueQueueType Queue { get; private set; }
        /// <summary>
        /// Gets summoners leagues entries for this League
        /// </summary>
        [JsonProperty("entries")]
        public SummonerLeague[] Entries { get; private set; }
    }
}
