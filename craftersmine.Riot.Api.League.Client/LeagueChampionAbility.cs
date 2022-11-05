using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends champion ability information
    /// </summary>
    public class LeagueChampionAbility
    {
        /// <summary>
        /// Gets an ability current level
        /// </summary>
        [JsonProperty("abilityLevel")]
        public int Level { get; private set; }
        /// <summary>
        /// Gets a localized ability name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }
        /// <summary>
        /// Gets an ID of ability
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
        /// <summary>
        /// Gets a raw internal ability description
        /// </summary>
        [JsonProperty("rawDescription")]
        public string RawDescription { get; private set; }
        /// <summary>
        /// Gets a raw internal ability name
        /// </summary>
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; private set; }
    }
}
