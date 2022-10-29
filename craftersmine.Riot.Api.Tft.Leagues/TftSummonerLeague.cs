using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.SummonerLeagues;
using craftersmine.Riot.Api.Tft.Leagues.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    /// <summary>
    /// Represents a Teamfight Tactics summoner ranked league
    /// </summary>
    public class TftSummonerLeague : SummonerLeague
    {
        /// <summary>
        /// Gets a TFT Hyper Roll rank tier
        /// </summary>
        [JsonProperty("ratedTier"), JsonConverter(typeof(TftHyperRollTierConverter))]
        public TftHyperRollTier HyperRollTier { get; private set; }
        /// <summary>
        /// Gets a TFT Hyper Roll rank rating
        /// </summary>
        [JsonProperty("ratedRating")]
        public int HyperRollRating { get; private set; }
    }
}
