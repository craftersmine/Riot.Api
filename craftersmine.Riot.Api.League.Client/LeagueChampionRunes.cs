using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends rune set
    /// </summary>
    public class LeagueChampionRunes
    {
        /// <summary>
        /// Gets an array of used runes
        /// </summary>
        [JsonProperty("generalRunes")]
        public LeagueChampionRune[] GeneralRunes { get; private set; }
        /// <summary>
        /// Gets main champion rune
        /// </summary>
        [JsonProperty("keystone")]
        public LeagueChampionRune Keystone { get; private set; }
        /// <summary>
        /// Gets primary rune tree type
        /// </summary>
        [JsonProperty("primaryRuneTree")]
        public LeagueChampionRune PrimaryRuneTree { get; private set; }
        /// <summary>
        /// Gets secondary rune tree type
        /// </summary>
        [JsonProperty("secondaryRuneTree")]
        public LeagueChampionRune SecondaryRuneTree { get; private set; }
        /// <summary>
        /// Gets stat runes
        /// </summary>
        [JsonProperty("statRunes")]
        public LeagueChampionRune[] StatRunes { get; private set; }
    }
}
