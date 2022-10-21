using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends elite monster kill timeline frame event
    /// </summary>
    public class EliteMonsterKillFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a bounty value for in gold for elite monster when it is was killed
        /// </summary>
        [JsonProperty("bounty")]
        public int Bounty { get; private set; }
        /// <summary>
        /// Gets a participant ID in this match of who is killed elite monster
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets an ID of team in this match which killed this elite monster
        /// </summary>
        [JsonProperty("killerTeamId")]
        public int KillerTeamId { get; private set; }
        /// <summary>
        /// Gets an array of participants IDs in this match which participated in kill
        /// </summary>
        [JsonProperty("assistingParticipantIds")]
        public int[] AssistingParticipantIds { get; private set; }
        /// <summary>
        /// Gets a subtype of elite monster which was killed
        /// </summary>
        [JsonProperty("monsterSubType"), JsonConverter(typeof(EliteMonsterSubtypeConverter))]
        public EliteMonsterSubtype MonsterSubtype { get; private set; }
        /// <summary>
        /// Gets a type of elite monster which was killed
        /// </summary>
        [JsonProperty("monsterType"), JsonConverter(typeof(EliteMonsterTypeConverter))]
        public EliteMonsterType MonsterType { get; private set; }
        /// <summary>
        /// Gets a League of Legends world position where this event happened
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
    }
}
