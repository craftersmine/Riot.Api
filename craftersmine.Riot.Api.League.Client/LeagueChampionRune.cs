using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends rune
    /// </summary>
    public class LeagueChampionRune
    {
        /// <summary>
        /// Gets rune ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets rune localized display name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }
        /// <summary>
        /// Gets rune internal raw description
        /// </summary>
        [JsonProperty("rawDescription")]
        public string RawDescription { get; private set; }
        /// <summary>
        /// Gets rune internal raw display name
        /// </summary>
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; private set; }
    }
}
