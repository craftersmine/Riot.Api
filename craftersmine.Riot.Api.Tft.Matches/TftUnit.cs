using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Tft.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents Teamfight Tactics unit
    /// </summary>
    public class TftUnit
    {
        /// <summary>
        /// Gets unit rarity
        /// </summary>
        [JsonProperty("rarity")]
        public int Rarity { get; private set; }
        /// <summary>
        /// Gets a unit IDs of items on this unit
        /// </summary>
        [JsonProperty("items")]
        public int[] ItemsIds { get; private set; }
        /// <summary>
        /// Gets a name of this unit
        /// </summary>
        /// <remarks>
        /// Most of the time remains blank
        /// </remarks>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets a unit character ID
        /// </summary>
        [JsonProperty("character_id")]
        public string CharacterId { get; private set; }
        /// <summary>
        /// Gets an array of names of items on this unit
        /// </summary>
        [JsonProperty("itemNames")]
        public string[] ItemNames { get; private set; }
        /// <summary>
        /// Gets a unit tier
        /// </summary>
        [JsonProperty("tier"), JsonConverter(typeof(TftUnitTierConverter))]
        public TftUnitTier Tier { get; private set; }
    }
}
