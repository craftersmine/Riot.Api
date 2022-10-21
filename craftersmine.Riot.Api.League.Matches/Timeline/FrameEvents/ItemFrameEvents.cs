using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends match timeline item change event (purchased, used, sold)
    /// </summary>
    public class ItemFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of item on which this event was occurred
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of participant in this match which performed an action with item
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
    }

    /// <summary>
    /// Represents a League of Legends match timeline item undo event
    /// </summary>
    public class ItemUndoFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of item that should be in slot after undo action
        /// </summary>
        /// <remarks>
        /// For health pots, wards it will be set to 0 indicating that one potion were removed from slot
        /// </remarks>
        [JsonProperty("afterId")]
        public int AfterId { get; private set; }
        /// <summary>
        /// Gets an ID of item that was in slot before undo action
        /// </summary>
        [JsonProperty("beforeId")]
        public int BeforeId { get; private set; }
        /// <summary>
        /// Gets a gold gained after item undo action
        /// </summary>
        [JsonProperty("goldGain")]
        public int GoldGain { get; private set; }
        /// <inheritdoc cref="ItemFrameEvent.ParticipantId"/>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
    }
}
