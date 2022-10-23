using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Challenges.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge information for player
    /// </summary>
    public class LeaguePlayerChallengeInfo
    {
        /// <summary>
        /// Gets an ID of challenge for which these stats are set
        /// </summary>
        [JsonProperty("challengeId")]
        public int ChallengeId { get; private set; }
        /// <summary>
        /// Gets a position in this challenge leaderboard of player if challenge level is master or higher
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; private set; }
        /// <summary>
        /// Gets an amount of players in current level if challenge level is master or higher
        /// </summary>
        [JsonProperty("playersInLevel")]
        public int PlayersInLevel { get; private set; }
        /// <summary>
        /// Gets a current value of challenge progress for player
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; private set; }
        /// <summary>
        /// Gets a current percentile on challenge leaderboard for player position
        /// </summary>
        [JsonProperty("percentile")]
        public float Percentile { get; private set; }
        /// <summary>
        /// Gets a current challenge level for player
        /// </summary>
        [JsonProperty("level"), JsonConverter(typeof(LeagueChallengeLevelConverter))]
        public LeagueChallengeLevel Level { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when player achieved current challenge level
        /// </summary>
        [JsonProperty("achievedTime"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime AchievedAt { get; private set; }
    }
}
