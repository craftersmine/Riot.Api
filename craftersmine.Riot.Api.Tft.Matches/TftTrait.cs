using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Tft.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics participant's trait in game
    /// </summary>
    public class TftTrait
    {
        /// <summary>
        /// Gets a total number of participant's units that have this trait
        /// </summary>
        [JsonProperty("num_units")]
        public int NumberOfUnits { get; private set; }
        /// <summary>
        /// Gets a current trait style
        /// </summary>
        [JsonProperty("style"), JsonConverter(typeof(TftTraitStyleConverter))]
        public TftTraitStyle Style { get; private set; }
        /// <summary>
        /// Gets current trait tier
        /// </summary>
        [JsonProperty("tier_current")]
        public int TierCurrent { get; private set; }
        /// <summary>
        /// Gets maximum possible trait tier
        /// </summary>
        [JsonProperty("tier_total")]
        public int TierTotal { get; private set; }
        /// <summary>
        /// Gets an internal trait name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}
