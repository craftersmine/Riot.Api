using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends challenge categories information for player
    /// </summary>
    public class LeagueChallengeCategories
    {
        /// <summary>
        /// Gets a current Imagination challenges category stats for player
        /// </summary>
        [JsonProperty("IMAGINATION")]
        public LeagueChallengeCategoryInfo Imagination { get; private set; }
        /// <summary>
        /// Gets a current Teamwork challenges category stats for player
        /// </summary>
        [JsonProperty("TEAMWORK")]
        public LeagueChallengeCategoryInfo Teamwork { get; private set; }
        /// <summary>
        /// Gets a current Expertise challenges category stats for player
        /// </summary>
        [JsonProperty("EXPERTISE")]
        public LeagueChallengeCategoryInfo Expertise { get; private set; }
        /// <summary>
        /// Gets a current Collection challenges category stats for player
        /// </summary>
        [JsonProperty("COLLECTION")]
        public LeagueChallengeCategoryInfo Collection { get; private set; }
        /// <summary>
        /// Gets a current Veterancy challenges category stats for player
        /// </summary>
        [JsonProperty("VETERANCY")]
        public LeagueChallengeCategoryInfo Veterancy { get; private set; }
    }
}
