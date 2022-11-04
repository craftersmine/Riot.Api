using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Valorant.Ranked
{
    /// <summary>
    /// Represents a Valorant tier details
    /// </summary>
    public class ValorantTierDetails
    {
        /// <summary>
        /// Gets a ranked rating threshold for this tier
        /// </summary>
        [JsonProperty("rankedRatingThreshold")]
        public int RankedRatingThreshold { get; private set; }
        /// <summary>
        /// Gets a starting page of data for this tier
        /// </summary>
        [JsonProperty("startingPage")]
        public int StartingPage { get; private set; }
        /// <summary>
        /// Gets a starting index of data for this tier
        /// </summary>
        [JsonProperty("startingIndex")]
        public int StartingIndex { get; private set; }
    }
}
