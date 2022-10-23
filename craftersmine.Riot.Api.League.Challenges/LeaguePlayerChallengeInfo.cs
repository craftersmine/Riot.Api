using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge information for player
    /// </summary>
    public class LeaguePlayerChallengeInfo : LeagueChallengeBaseInfo
    {
        /// <summary>
        /// Gets an ID of challenge for which these stats are set
        /// </summary>
        [JsonProperty("challengeId")]
        public int ChallengeId { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when player achieved current challenge level
        /// </summary>
        [JsonProperty("achievedTime"), JsonConverter(typeof(UnixDateTimeConverter), true)]
        public DateTime AchievetAt { get; private set; }
    }
}
