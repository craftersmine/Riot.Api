using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends item information
    /// </summary>
    public class LeagueItem
    {
        /// <summary>
        /// Gets total amount of items in stack
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }
        /// <summary>
        /// Gets item ID
        /// </summary>
        [JsonProperty("itemID")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets item buy price
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; private set; }
        /// <summary>
        /// Gets slot ID in which this item is located in player's inventory
        /// </summary>
        [JsonProperty("slot")]
        public int Slot { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this item can be used by player, otherwise <see langword="false"/>
        /// </summary>
        [JsonProperty("canUse")]
        public bool CanUse { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this item is consumable by player, otherwise <see langword="false"/>
        /// </summary>
        [JsonProperty("consumable")]
        public bool IsConsumable { get; private set; }
        /// <summary>
        /// Gets item localized name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }
        /// <summary>
        /// Gets item internal raw description
        /// </summary>
        [JsonProperty("rawDescription")]
        public string RawDescription { get; private set; }
        /// <summary>
        /// Gets item internal raw display name
        /// </summary>
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; private set; }
    }
}
