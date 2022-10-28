using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.SummonerLeagues;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    /// <summary>
    /// Represents a Teamfight Tactics Ranked Leagues list
    /// </summary>
    public class TftLeagueList : LeagueList
    {
        /// <summary>
        /// Gets current ranked Leagues list entries
        /// </summary>
        [JsonProperty("entries")]
        public new TftSummonerLeague[] Entries { get; private set; }
    }
}
