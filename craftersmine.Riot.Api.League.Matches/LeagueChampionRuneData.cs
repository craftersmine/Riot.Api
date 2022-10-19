using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends post game champion rune values
    /// </summary>
    public class LeagueChampionRuneData
    {
        /// <summary>
        /// Gets a League of Legends rune ID for this data
        /// </summary>
        [JsonProperty("perk")]
        public int RuneId { get; private set; }
        /// <summary>
        /// Gets a first value for this rune
        /// </summary>
        [JsonProperty("var1")]
        public int RuneValue1 { get; private set; }
        /// <summary>
        /// Gets a second value for this rune
        /// </summary>
        [JsonProperty("var2")]
        public int RuneValue2 { get; private set; }
        /// <summary>
        /// Gets a third value for this rune
        /// </summary>
        [JsonProperty("var3")]
        public int RuneValue3 { get; private set; }
    }
}
