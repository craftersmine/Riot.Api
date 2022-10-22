using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline
    /// </summary>
    public class LeagueMatchTimeline
    {
        /// <inheritdoc cref="LeagueMatch.Metadata"/>
        [JsonProperty("metadata")]
        public LeagueMatchMetadata Metadata { get; private set; }
        /// <summary>
        /// Gets a League of Legends match timeline data
        /// </summary>
        [JsonProperty("info")]
        public LeagueMatchTimelineInfo Timeline { get; private set; }
    }
}
