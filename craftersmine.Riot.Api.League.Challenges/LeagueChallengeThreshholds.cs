using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge thresholds for reaching specific challenge rank
    /// </summary>
    public class LeagueChallengeThresholds
    {
        /// <summary>
        /// Gets a minimum value for challenge to have an Iron badge
        /// </summary>
        [JsonProperty("iron")]
        public int Iron { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Bronze badge
        /// </summary>
        [JsonProperty("bronze")]
        public int Bronze { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Silver badge
        /// </summary>
        [JsonProperty("silver")]
        public int Silver { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Gold badge
        /// </summary>
        [JsonProperty("gold")]
        public int Gold { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Platinum badge
        /// </summary>
        [JsonProperty("platinum")]
        public int Platinum { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Diamond badge
        /// </summary>
        [JsonProperty("diamond")]
        public int Diamond { get; private set; }
        /// <summary>
        /// Gets a minimum value for challenge to have a Master badge
        /// </summary>
        [JsonProperty("master")]
        public int Master { get; private set; }
    }
}
