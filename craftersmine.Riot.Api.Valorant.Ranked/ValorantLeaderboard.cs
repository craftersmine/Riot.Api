using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Valorant.Ranked
{
    /// <summary>
    /// Represents a Valorant Leaderboard
    /// </summary>
    public class ValorantLeaderboard
    {
        /// <summary>
        /// Gets a starting page for immortal ranked
        /// </summary>
        [JsonProperty("immortalStartingPage")]
        public int ImmortalStartingPage { get; private set; }
        /// <summary>
        /// Gets a starting index for immortal ranked
        /// </summary>
        [JsonProperty("immortalStartingIndex")]
        public int ImmortalStartingIndex { get; private set; }
        /// <summary>
        /// Gets a RR threshold for top tier
        /// </summary>
        [JsonProperty("topTierRRThreshold")]
        public int TopTierRRThreshold { get; private set; }
        /// <summary>
        /// Gets a current requested start index
        /// </summary>
        [JsonProperty("startIndex")]
        public int StartIndex { get; private set; }
        /// <summary>
        /// Gets a total amount of players in current leaderboard
        /// </summary>
        [JsonProperty("totalPlayers")]
        public long TotalPlayers { get; private set; }
        /// <summary>
        /// Gets a query string
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; private set; }
        /// <summary>
        /// Gets a leaderboard shard region
        /// </summary>
        [JsonProperty("shard"), JsonConverter(typeof(RiotShardConverter))]
        public RiotShards Shard { get; private set; }
        /// <summary>
        /// Gets a leaderboard act ID
        /// </summary>
        [JsonProperty("actId")]
        public Guid ActId { get; private set; }
        /// <summary>
        /// Gets an array of leaderboard players information
        /// </summary>
        [JsonProperty("players")]
        public ValorantPlayer[] Players { get; private set; }
        /// <summary>
        /// Gets a collection for competitive tier details
        /// </summary>
        [JsonProperty("tierDetails")]
        public ValorantTierDetailsCollection TierDetails { get; private set; }
    }
}
