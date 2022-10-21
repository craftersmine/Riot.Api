using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends team objective
    /// </summary>
    public class LeagueObjective
    {
        /// <summary>
        /// Gets number of objective kills for team
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if team first killed this objective
        /// </summary>
        [JsonProperty("first")]
        public bool FirstKill { get; private set; }
    }
}
