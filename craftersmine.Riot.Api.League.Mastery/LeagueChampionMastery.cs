using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Mastery
{
    /// <summary>
    /// Represents a mastery information for specific champion
    /// </summary>
    public class LeagueChampionMastery
    {
        /// <summary>
        /// Gets a League of Legends internal champion ID
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
        /// <summary>
        /// Gets current League of Legends Mastery level on this champion
        /// </summary>
        [JsonProperty("championLevel")]
        public int MasteryLevel { get; private set; }
        /// <summary>
        /// Gets current League of Legends Mastery points earned on this champion
        /// </summary>
        [JsonProperty("championPoints")]
        public int MasteryPoints { get; private set; }
        /// <summary>
        /// Gets League of Legends Mastery points earned since last Mastery Level-up on this champion
        /// </summary>
        [JsonProperty("championPointsSinceLastLevel")]
        public int MasteryPointsSinceLastMasteryLevel { get; private set; }
        /// <summary>
        /// Gets League of Legends Mastery points needed to be earned for next Mastery level-up on this champion
        /// </summary>
        [JsonProperty("championPointsUntilNextLevel")]
        public int MasteryPointsUntilMasteryLevelUp { get; private set; }
        /// <summary>
        /// Gets League of Legends Mastery tokens earned for this champion to level-up Mastery level
        /// </summary>
        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if player earned a chest on this champion in this season, otherwise <see langword="false"/>
        /// </summary>
        [JsonProperty("chestGranted")]
        public bool IsChestGranted { get; private set; }
        /// <summary>
        /// Gets a League of Legends summoner ID that has this <see cref="LeagueChampionMastery"/> information related to
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> of time the player has played on this champion in GMT timezone
        /// </summary>
        [JsonProperty("lastPlayTime"), JsonConverter(typeof(Common.Converters.UnixDateTimeConverter))]
        public DateTime LastPlayedAt { get; private set; }
    }
}
