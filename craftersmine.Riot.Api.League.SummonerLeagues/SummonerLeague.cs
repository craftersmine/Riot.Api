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
        public string? SummonerId { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string? SummonerName { get; private set; }
        /// <summary>
        /// Gets League of Legends Queue type for League
        /// </summary>
        [JsonProperty("queueType"), JsonConverter(typeof(LeagueQueueTypeConverter))]
        public LeagueQueueType LeagueQueueType { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner ranked tier
        /// </summary>
        [JsonProperty("tier"), JsonConverter(typeof(LeagueRankedTierConverter))]
        public LeagueRankedTier Tier { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rank"), JsonConverter(typeof(LeagueDivisionRankConverter))]
        public LeagueDivisionRank DivisionRank { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner ranked LP value
        /// </summary>
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner win count
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }
        /// <summary>
        /// Gets League of Legends summoner loss count
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if League of Legends summoner has a hot streak (win streak)
        /// </summary>
        [JsonProperty("hotStreak")]
        public bool IsHotStreak { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if League of Legends summoner is a veteran player
        /// </summary>
        [JsonProperty("veteran")]
        public bool IsVeteran { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if League of Legends summoner is a new player
        /// </summary>
        [JsonProperty("freshBlood")]
        public bool IsFreshBlood { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if League of Legends summoner is inactive (was not logged in for too long)
        /// </summary>
        [JsonProperty("inactive")]
        public bool IsInactive { get; private set; }
    }
}
