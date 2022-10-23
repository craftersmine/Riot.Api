using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a localized strings for League of Legends challenge information
    /// </summary>
    public class LeagueChallengeName
    {
        /// <summary>
        /// Gets a localized League of Legends challenge description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// Gets a localized League of Legends challenge name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets a localized League of Legends challenge short description
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; private set; }
    }
}
