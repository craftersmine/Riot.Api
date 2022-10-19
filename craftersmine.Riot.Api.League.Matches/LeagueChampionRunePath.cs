using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends rune path (primary or secondary)
    /// </summary>
    public class LeagueChampionRunePath
    {
        /// <summary>
        /// Gets a type of rune path (primary or secondary)
        /// </summary>
        [JsonProperty("description"), JsonConverter(typeof(LeagueChampionRunePathStyleConverter))]
        public LeagueChampionRunePathStyle PathStyle { get; private set; }
        /// <summary>
        /// Gets an post game information about runes in this rune path
        /// </summary>
        [JsonProperty("selections")]
        public LeagueChampionRuneData[] RunesData { get; private set; }
        /// <summary>
        /// Gets a main rune type for this path (ex. Domination, Resolve, etc.)
        /// </summary>
        [JsonProperty("style")]
        public int PathId { get; private set; }
    }
}
