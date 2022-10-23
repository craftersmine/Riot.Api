using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Challenges.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge
    /// </summary>
    public class LeagueChallenge
    {
        /// <summary>
        /// Gets a League of Legends challenge ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this challenge being included in leaderboard
        /// </summary>
        [JsonProperty("leaderboard")]
        public bool IsLeaderboardEnabled { get; private set; }
        /// <summary>
        /// Gets a current League of Legends challenge state
        /// </summary>
        [JsonProperty("state"), JsonConverter(typeof(LeagueChallengeStateConverter))]
        public LeagueChallengeState State { get; private set; }
        /// <summary>
        /// Gets a current League of Legends challenge tracking state
        /// </summary>
        [JsonProperty("tracking"), JsonConverter(typeof(LeagueChallengeTrackingStateConverter))]
        public LeagueChallengeTrackingState Tracking { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when challenge is being started calculated
        /// </summary>
        [JsonProperty("startTimestamp"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTimestamp { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when challenge will be stopped being calculated
        /// </summary>
        [JsonProperty("endTimestamp"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndTimestamp { get; private set; }
        /// <summary>
        /// Gets a collection of localized challenge names and descriptions
        /// </summary>
        [JsonProperty("localizedNames")]
        public LeagueChallengeNamesCollection LocalizedNames { get; private set; }
        /// <summary>
        /// Gets a set of values that needs to be met for challenge to have specific badge
        /// </summary>
        [JsonProperty("thresholds")]
        public LeagueChallengeThresholds Thresholds { get; private set; }
    }
}
