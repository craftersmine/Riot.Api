using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends player preferences for challenges in League Client (tokens, title, etc.)
    /// </summary>
    public class LeagueChallengesPlayerClientPreferences
    {
        // TODO (craftersmine): determine what this property is returning.
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bannerAccent")]
        public string BannerAccent { get; private set; }
        /// <summary>
        /// Gets a selected title ID that player selected to be shown
        /// </summary>
        [JsonProperty("title")]
        public int TitleId { get; private set; }
        /// <summary>
        /// Gets a selected challenge IDs for tokens by player to be shown
        /// </summary>
        [JsonProperty("challengeIds")]
        public int[] ChallengeTokensIds { get; private set; }
    }
}
