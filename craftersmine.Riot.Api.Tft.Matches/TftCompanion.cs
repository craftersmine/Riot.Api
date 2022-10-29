using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics participant's tactician
    /// </summary>
    public class TftCompanion
    {
        /// <summary>
        /// Gets a tactician ID
        /// </summary>
        [JsonProperty("item_ID")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets a tactician skin ID
        /// </summary>
        [JsonProperty("skin_ID")]
        public int SkinId { get; private set; }
        /// <summary>
        /// Gets a tactician content ID
        /// </summary>
        [JsonProperty("content_ID")]
        public string ContentId { get; private set; }
        /// <summary>
        /// Gets a tactician species string
        /// </summary>
        [JsonProperty("species")]
        public string Species { get; private set; }
    }
}
