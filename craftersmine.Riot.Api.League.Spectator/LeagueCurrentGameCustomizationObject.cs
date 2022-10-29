using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a League of Legends game customization object information
    /// </summary>
    public class LeagueCurrentGameCustomizationObject
    {
        /// <summary>
        /// Gets a game customization object category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; private set; }
        /// <summary>
        /// Gets a game customization object content data
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; private set; }
    }
}
