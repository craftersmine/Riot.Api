using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends champion abilities information
    /// </summary>
    public class LeagueChampionAbilities
    {
        /// <summary>
        /// Gets a champion passive ability
        /// </summary>
        [JsonProperty("Passive")]
        public LeagueChampionAbility Passive { get; private set; }
        /// <summary>
        /// Gets a champion Q ability
        /// </summary>
        [JsonProperty("Q")]
        public LeagueChampionAbility Q { get; private set; }
        /// <summary>
        /// Gets a champion W ability
        /// </summary>
        [JsonProperty("W")]
        public LeagueChampionAbility W { get; private set; }
        /// <summary>
        /// Gets a champion E ability
        /// </summary>
        [JsonProperty("E")]
        public LeagueChampionAbility E { get; private set; }
        /// <summary>
        /// Gets a champion R ability
        /// </summary>
        [JsonProperty("R")]
        public LeagueChampionAbility R { get; private set; }
    }
}
