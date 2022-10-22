using System;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends timeline participant data per frame
    /// </summary>
    public class LeagueMatchTimelineParticipantFrame
    {
        /// <summary>
        /// Gets a current gold participant has in it's pockets at frame capture moment
        /// </summary>
        [JsonProperty("currentGold")]
        public int CurrentGold { get; private set; }
        /// <summary>
        /// Gets a current participant's champion level at frame capture moment
        /// </summary>
        [JsonProperty("level")]
        public int ChampionLevel { get; private set; }
        /// <summary>
        /// Gets a total amount of experience participant's champion at frame capture moment
        /// </summary>
        [JsonProperty("xp")]
        public int Experience { get; private set; }
        /// <summary>
        /// Gets a gold income per second of participant
        /// </summary>
        [JsonProperty("goldPerSecond")]
        public int GoldPerSecond { get; private set; }
        /// <summary>
        /// Gets a total amount of jungle monsters was killed by participant
        /// </summary>
        [JsonProperty("jungleMonstersKilled")]
        public int JungleMonstersKilled { get; private set; }
        /// <summary>
        /// Gets a total amount of minions killed (including jungle monsters) at frame capture moment
        /// </summary>
        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; private set; }
        /// <summary>
        /// Gets a participant ID in this match
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
        /// <summary>
        /// Gets a total amount of gold was earned by participant at frame capture moment
        /// </summary>
        [JsonProperty("totalGold")]
        public int TotalGold { get; private set; }
        /// <summary>
        /// Gets a participant's champion position in world at frame capture moment
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
        /// <summary>
        /// Gets a total <see cref="TimeSpan"/> of enemy champions being crowd controlled by participant's champion at frame capture moment
        /// </summary>
        [JsonProperty("timeEnemySpentControlled"), JsonConverter(typeof(UnixTimeSpanConverter), false)]
        public TimeSpan TimeEnemySpentControlled { get; private set; }
        /// <summary>
        /// Gets a current stats of participant's champion at frame capture moment
        /// </summary>
        [JsonProperty("championStats")]
        public LeagueChampionStats ChampionStats { get; private set; }
        /// <summary>
        /// Gets a current damage stats of participant's champion at frame capture moment
        /// </summary>
        [JsonProperty("damageStats")]
        public LeagueChampionDamageStats ChampionDamageStats { get; private set; }
    }
}
