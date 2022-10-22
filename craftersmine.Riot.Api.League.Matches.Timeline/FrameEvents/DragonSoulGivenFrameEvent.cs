using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends dragon soul being captured timeline frame event
    /// </summary>
    public class DragonSoulGivenFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a team ID which captured dragon soul in the match
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets a name of dragon soul that was captured
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        // TODO (craftersmine): add enum for dragon soul name?
    }
}
