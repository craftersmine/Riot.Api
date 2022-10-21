using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents League of Legends team objectives
    /// </summary>
    public class LeagueObjectives
    {
        /// <summary>
        /// Gets a League of Legends "Baron Nashor" objective information for team
        /// </summary>
        [JsonProperty("baron")]
        public LeagueObjective Baron { get; private set; }
        /// <summary>
        /// Gets a League of Legends "Champion" objective information for team
        /// </summary>
        [JsonProperty("champion")]
        public LeagueObjective Champion { get; private set; }
        /// <summary>
        /// Gets a League of Legends "Dragon" objective information for team
        /// </summary>
        [JsonProperty("dragon")]
        public LeagueObjective Dragon { get; private set; }
        /// <summary>
        /// Gets a League of Legends "Inhibitor" objective information for team
        /// </summary>
        [JsonProperty("inhibitor")]
        public LeagueObjective Inhibitor { get; private set; }
        /// <summary>
        /// Gets a League of Legends "Rift Herald" objective information for team
        /// </summary>
        [JsonProperty("riftHerald")]
        public LeagueObjective RiftHerald { get; private set; }
        /// <summary>
        /// Gets a League of Legends "Tower" objective information for team
        /// </summary>
        [JsonProperty("tower")]
        public LeagueObjective Tower { get; private set; }
    }
}
