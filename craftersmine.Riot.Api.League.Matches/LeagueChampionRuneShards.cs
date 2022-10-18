using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends selected rune shards
    /// </summary>
    public class LeagueChampionRuneShards
    {
        /// <summary>
        /// Gets an ID of League of Legends selected defense rune shard
        /// </summary>
        [JsonProperty("defense")]
        public int DefenseShardId { get; private set; }
        /// <summary>
        /// Gets an ID of League of Legends selected flex rune shard
        /// </summary>
        [JsonProperty("flex")]
        public int FlexShardId { get; private set; }
        /// <summary>
        /// Gets an ID of League of Legends selected offense rune shard
        /// </summary>
        [JsonProperty("offense")]
        public int OffenseShardId { get; private set; }
    }
}
