using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends champion transformation timeline frame event
    /// </summary>
    /// <remarks>
    /// Currently only for Kayn transformations <br/>
    /// This event can also occur when Viego possess Kayn, <br/>
    /// because Viego basically becomes Kayn for a brief period of time
    /// </remarks>
    public class ChampionTransformFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a participant ID in this match who performed transform
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
        /// <summary>
        /// Gets a type of transformation after champion was transformed
        /// </summary>
        [JsonProperty("transformType"), JsonConverter(typeof(LeagueChampionTransformConverter))]
        public LeagueChampionTransform TransformType { get; private set; }
    }
}
