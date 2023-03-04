using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends player that currently has running League Game Client
    /// </summary>
    public class LeagueActivePlayerData
    {
        /// <summary>
        /// Gets player's champion level
        /// </summary>
        [JsonProperty("level")]
        public int ChampionLevel { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if player has enabled relative team colors
        /// </summary>
        [JsonProperty("teamRelativeColors")]
        public bool HasRelativeTeamColors { get; private set; }
        /// <summary>
        /// Gets current player's gold value in store
        /// </summary>
        [JsonProperty("currentGold")]
        public double CurrentGold { get; private set; }
        /// <summary>
        /// Gets current player's summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets current player's champion abilities
        /// </summary>
        [JsonProperty("abilities")]
        public LeagueChampionAbilities Abilities { get; private set; }
        /// <summary>
        /// Gets current player's champion stats
        /// </summary>
        [JsonProperty("championStats")]
        public LeagueChampionStats ChampionStats { get; private set; }
        /// <summary>
        /// Gets current player's selected runes
        /// </summary>
        [JsonProperty("fullRunes")]
        public LeagueChampionRunes Runes { get; private set; }
    }
}
