using System;
using System.Collections.Generic;
using System.Text;

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
        /// <summary>
        /// Gets <see langword="true"/> if player has enabled relative team colors
        /// </summary>
        public bool HasRelativeTeamColors { get; private set; }
        /// <summary>
        /// Gets current player's gold value in store
        /// </summary>
        public double CurrentGold { get; private set; }
        /// <summary>
        /// Gets current player's summoner name
        /// </summary>
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets current player's champion abilities
        /// </summary>
        public LeagueChampionAbilities Abilities { get; private set; }
        /// <summary>
        /// Gets current player's champion stats
        /// </summary>
        public LeagueChampionStats ChampionStats { get; private set; }
        public LeaguePlayerRunes Runes { get; private set; }
    }
}
