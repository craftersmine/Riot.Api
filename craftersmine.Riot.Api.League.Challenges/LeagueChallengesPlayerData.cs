using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenges data for player
    /// </summary>
    public class LeagueChallengesPlayerData
    {
        /// <summary>
        /// Gets a total information for challenges of player
        /// </summary>
        [JsonProperty("totalPoints")]
        public LeagueChallengeCategoryInfo TotalPoints { get; private set; }
        /// <summary>
        /// Gets an information about challenge categories of player
        /// </summary>
        [JsonProperty("categoryPoints")]
        public LeagueChallengeCategories CategoryPoints { get; private set; }
        /// <summary>
        /// Gets a collection of challenge infos for player
        /// </summary>
        [JsonProperty("challenges")]
        public LeaguePlayerChallengeInfosCollection Challenges { get; private set; }
        /// <summary>
        /// Gets a current League Client preferences specific to challenges
        /// </summary>
        [JsonProperty("preferences")]
        public LeagueChallengesPlayerClientPreferences ClientPreferences { get; private set; }
    }
}
