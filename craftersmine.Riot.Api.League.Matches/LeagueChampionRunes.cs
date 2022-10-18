using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends rune set
    /// </summary>
    public class LeagueChampionRunes
    {
        /// <summary>
        /// Gets a League of Legends selected rune shards for champion
        /// </summary>
        [JsonProperty("statPerks")]
        public LeagueChampionRuneShards Shards { get; private set; }
        /// <summary>
        /// Gets a League of Legends selected rune paths for champion
        /// </summary>
        [JsonProperty("styles")]
        public LeagueChampionRunePath[] Paths { get; private set; }
    }
}
