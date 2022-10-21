using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends building destroyed timeline frame event
    /// </summary>
    public class BuildingKillFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a bounty value for destroyed building
        /// </summary>
        [JsonProperty("bounty")]
        public int Bounty { get; private set; }
        /// <summary>
        /// Gets a participant ID in this match who is destroyed this building
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets an ID of team in which killer participant was part of
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets an array of participant IDs in this match who assisted in destroying building
        /// </summary>
        [JsonProperty("assistingParticipantIds")]
        public int[] AssistingParticipantIds { get; private set; }
        /// <summary>
        /// Gets a type of destroyed building
        /// </summary>
        [JsonProperty("buildingType"), JsonConverter(typeof(LeagueBuildingTypeConverter))]
        public LeagueBuildingType BuildingType { get; private set; }
        /// <summary>
        /// Gets a League of Legends lane on which building was destroyed
        /// </summary>
        [JsonProperty("laneType"), JsonConverter(typeof(LeagueLaneConverter))]
        public LeagueLane LaneType { get; private set; }
        /// <summary>
        /// Gets a type of tower if building was tower
        /// </summary>
        [JsonProperty("towerType"), JsonConverter(typeof(LeagueTowerTypeConverter))]
        public LeagueTowerType TowerType { get; private set; }
        /// <summary>
        /// Gets a position where event is occurred
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
    }
}
