using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Account
{
    /// <summary>
    /// Represents a Riot Active Shard for account
    /// </summary>
    public class RiotActiveShard
    {
        /// <summary>
        /// Gets a Riot Account PUUID
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a Riot Shard Game value for active shard
        /// </summary>
        [JsonProperty("game"), JsonConverter(typeof(RiotShardGameConverter))]
        public RiotShardGame Game { get; private set; }
        /// <summary>
        /// Gets a current active data shard for account
        /// </summary>
        [JsonProperty("activeShard"), JsonConverter(typeof(RiotShardConverter))]
        public RiotShards ActiveShard { get; private set; }
    }
}
