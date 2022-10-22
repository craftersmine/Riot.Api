using craftersmine.Riot.Api.League.Matches.Timeline.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends turret plating destroying timeline frame event
    /// </summary>
    public class TurretPlateDestroyedFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a participant ID which destroyed a turret plate
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets a team ID of participant which destroyed a turret plate
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets a League of Legends lane on which turret plate was destroyed
        /// </summary>
        [JsonProperty("laneType"), JsonConverter(typeof(LeagueLaneConverter))]
        public LeagueLane Lane { get; private set; }
        /// <summary>
        /// Gets a position in League of Legends world where this event is occurred
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
    }
}
