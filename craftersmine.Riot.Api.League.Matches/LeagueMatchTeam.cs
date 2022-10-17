using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends match team
    /// </summary>
    public class LeagueMatchTeam
    {
        /// <summary>
        /// Gets a League of Legends match team ID
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if team is won this match
        /// </summary>
        [JsonProperty("win")]
        public bool IsWon { get; private set; }
        /// <summary>
        /// Gets a League of Legends objectives information for this team
        /// </summary>
        [JsonProperty("objectives")]
        public LeagueObjectives Objectives { get; private set; }
        /// <summary>
        /// Gets a set of League of Legends match bans for this team
        /// </summary>
        [JsonProperty("bans")]
        public LeagueMatchBan[] Bans { get; private set; }
    }
}
