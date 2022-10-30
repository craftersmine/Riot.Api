using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Valorant.Content
{
    /// <summary>
    /// Represents a Valorant Act
    /// </summary>
    public class ValorantAct
    {
        /// <summary>
        /// Gets <see langword="true"/> if this act is currently active
        /// </summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; private set; }
        /// <summary>
        /// Gets a neutral localized name for item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets an ID of content item
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; private set; }
        /// <summary>
        /// Gets a parent act ID
        /// </summary>
        [JsonProperty("parentId")]
        public Guid ParentId { get; private set; }
        /// <summary>
        /// Gets a type of act
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public ValorantActType Type { get; private set; }
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
