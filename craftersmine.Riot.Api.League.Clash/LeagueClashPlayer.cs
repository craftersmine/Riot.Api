using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Clash.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents League of Legends Clash player
    /// </summary>
    public class LeagueClashPlayer
    {
        /// <summary>
        /// Gets a League of Legends Summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets a League of Legends Clash Team ID
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; private set; }
        /// <summary>
        /// Gets a League of Legends player desired position
        /// </summary>
        [JsonProperty("position"), JsonConverter(typeof(LeaguePlayerPositionConverter))]
        public LeaguePlayerPosition Position { get; private set; }
        /// <summary>
        /// Gets a League of Legends player role in the team
        /// </summary>
        [JsonProperty("role"), JsonConverter(typeof(LeagueClashTeamRoleConverter))]
        public LeagueClashTeamRole Role { get; private set; }
    }
}
