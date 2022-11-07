using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends summoner spell
    /// </summary>
    public class LeagueSummonerSpell
    {
        /// <summary>
        /// Gets a localized name of summoner spell
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }
        /// <summary>
        /// Gets an internal raw description of summoner spell
        /// </summary>
        [JsonProperty("rawDescription")]
        public string RawDescription { get; private set; }
        /// <summary>
        /// Gets an internal raw display name of summoner spell
        /// </summary>
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; private set; }
    }
}
