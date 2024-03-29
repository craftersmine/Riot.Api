﻿using System;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents any of League of Legends match timeline frame event
    /// </summary>
    public interface ILeagueTimelineFrameEvent
    {
        /// <summary>
        /// Gets a League of Legends match timeline frame event type
        /// </summary>
        LeagueTimelineFrameEventType Type { get; }
        /// <summary>
        /// Gets a League of Legends match timeline frame event timestamp within match from game start
        /// </summary>
        TimeSpan Timestamp { get; }
    }
}
