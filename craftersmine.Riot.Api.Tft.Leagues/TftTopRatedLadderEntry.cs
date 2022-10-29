using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Tft.Leagues.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    /// <summary>
    /// Represents a Teamfight Tactics Hyper Roll top rated ladder entry
    /// </summary>
    public class TftHyperRollTopRatedLadderEntry
    {
        /// <summary>
        /// Gets current Hyper Roll player rating
        /// </summary>
        [JsonProperty("ratedRating")]
        public int HyperRollRating { get; private set; }
        /// <summary>
        /// Gets previous player ladder position before ladder update
        /// </summary>
        [JsonProperty("previousUpdateLadderPosition")]
        public int PreviousUpdateLadderPosition { get; private set; }
        /// <summary>
        /// Gets total amount of first placements for player
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }
        /// <summary>
        /// Gets Teamfight Tactics / League of Legends summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets Teamfight Tactics / League of Legends summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets current Hyper Roll player rank tier
        /// </summary>
        [JsonProperty("ratedTier"), JsonConverter(typeof(TftHyperRollTierConverter))]
        public TftHyperRollTier HyperRollTier { get; private set; }
    }
}
