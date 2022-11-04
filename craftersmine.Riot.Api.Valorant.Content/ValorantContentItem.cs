using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Valorant.Content
{
    /// <summary>
    /// Represents a Valorant Content Item
    /// </summary>
    public class ValorantContentItem
    {
        /// <summary>
        /// Gets a neutral localized name for item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets an internal game asset name
        /// </summary>
        [JsonProperty("assetName")]
        public string AssetName { get; private set; }
        /// <summary>
        /// Gets an internal game asset path within game packed assets
        /// </summary>
        [JsonProperty("assetPath")]
        public string AssetPath { get; private set; }
        /// <summary>
        /// Gets an ID of content item
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; private set; }
        /// <summary>
        /// Gets localized names for this item
        /// </summary>
        /// <remarks>
        /// This could be an empty collection or <see langword="null"/> when filtering by locale is set
        /// </remarks>
        [JsonProperty("localizedNames")]
        public ValorantLocalizedNamesCollection LocalizedNames { get; private set; }
    }
}
