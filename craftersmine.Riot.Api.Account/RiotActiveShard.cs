using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace craftersmine.Riot.Api.Account
{
    public class RiotActiveShard
    {
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        [JsonProperty("game"), JsonConverter(typeof(RiotShardGameConverter))]
        public RiotShardGame Game { get; private set; }
        [JsonProperty("activeShard"), JsonConverter(typeof(RiotShardConverter))]
        public RiotShards ActiveShard { get; private set; }
    }
}
