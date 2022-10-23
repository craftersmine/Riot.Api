using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge percentiles of players achieved certain rank of challenge
    /// </summary>
    public class LeagueChallengePercentiles
    {
        /// <summary>
        /// Gets a percentile of players that achieved Iron badge
        /// </summary>
        [JsonProperty("iron")]
        public float Iron { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Bronze badge
        /// </summary>
        [JsonProperty("bronze")]
        public float Bronze { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Silver badge
        /// </summary>
        [JsonProperty("silver")]
        public float Silver { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Gold badge
        /// </summary>
        [JsonProperty("gold")]
        public float Gold { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Platinum badge
        /// </summary>
        [JsonProperty("platinum")]
        public float Platinum { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Diamond badge
        /// </summary>
        [JsonProperty("diamond")]
        public float Diamond { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Master badge
        /// </summary>
        [JsonProperty("master")]
        public float Master { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Grandmaster badge
        /// </summary>
        [JsonProperty("grandmaster")]
        public float Grandmaster { get; private set; }
        /// <summary>
        /// Gets a percentile of players that achieved Challenger badge
        /// </summary>
        [JsonProperty("challenger")]
        public float Challenger { get; private set; }
    }
}
