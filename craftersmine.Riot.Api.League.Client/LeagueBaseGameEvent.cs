using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends base game event
    /// </summary>
    public class LeagueBaseGameEvent : ILeagueGameEvent
    {
        /// <summary>
        /// Gets event index in event timeline
        /// </summary>
        public int EventId { get; private set; }
        /// <summary>
        /// Gets <see cref="TimeSpan"/> timestamp when this event has occurred
        /// </summary>
        public TimeSpan EventTime { get; private set; }
        /// <summary>
        /// Gets a type of event
        /// </summary>
        public LeagueGameEventType EventType { get; private set; }
    }
}
