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
    /// Represents a League of Legends summoner current league (ranked data)
    /// </summary>
    public class SummonerLeague
    {
        /// <summary>
        /// Gets league ID
        /// </summary>
        [JsonProperty("leagueId")]
        public string Id { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets League of Legends Queue type for League
        /// </summary>
        [JsonProperty("queueType"), JsonConverter(typeof(LeagueQueueTypeConverter))]
        public LeagueQueueType LeagueQueueType { get; private set; }


    }
}
