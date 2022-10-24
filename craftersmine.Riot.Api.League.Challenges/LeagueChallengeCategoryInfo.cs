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
    public class LeagueChallengeCategoryInfo
    {
        /// <summary>
        /// Gets current challenge category value for player
        /// </summary>
        [JsonProperty("current")]
        public int CurrentValue { get; private set; }
        /// <summary>
        /// Gets a maximum value for challenge category that can be achieved
        /// </summary>
        [JsonProperty("max")]
        public int MaxValue { get; private set; }
        /// <summary>
        /// Gets a current percentile on challenge category leaderboard for player position
        /// </summary>
        [JsonProperty("percentile")]
        public float Percentile { get; private set; }
        /// <summary>
        /// Gets current challenge category level for player
        /// </summary>
        [JsonProperty("level"), JsonConverter(typeof(LeagueChallengeLevelConverter))]
        public LeagueChallengeLevel Level { get; private set; }
    }
}
