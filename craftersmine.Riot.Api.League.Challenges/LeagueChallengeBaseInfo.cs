using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Challenges.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents basic League of Legends information about challenge for player
    /// </summary>
    public class LeagueChallengeBaseInfo
    {
        /// <summary>
        /// Gets current challenge value for player
        /// </summary>
        [JsonProperty("current")]
        public int CurrentValue { get; private set; }
        /// <summary>
        /// Gets a required challenge value for player to level up to next challenge level
        /// </summary>
        [JsonProperty("max")]
        public int ValueRequiredForLevelUp { get; private set; }
        /// <summary>
        /// Gets a current percentile on challenge leaderboard for player position
        /// </summary>
        [JsonProperty("percentile")]
        public float Percentile { get; private set; }
        /// <summary>
        /// Gets current challenge level for player
        /// </summary>
        [JsonProperty("level"), JsonConverter(typeof(LeagueChallengeLevelConverter))]
        public LeagueChallengeLevel Level { get; private set; }
    }
}
