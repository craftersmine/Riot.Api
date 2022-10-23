using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a localized Riot Service status message
    /// </summary>
    public class RiotServiceStatusContent
    {
        /// <summary>
        /// Gets a localized content for Riot Service status message
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; private set; }
        /// <summary>
        /// Gets a corresponding culture info for Riot Service status message locale
        /// </summary>
        [JsonProperty("locale"), JsonConverter(typeof(Common.Converters.CultureInfoConverter))]
        public CultureInfo Locale { get; private set; }
    }
}
