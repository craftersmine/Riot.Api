using craftersmine.Riot.Api.Common.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League game event
    /// </summary>
    public interface ILeagueGameEvent
    {
        /// <summary>
        /// Gets an ID of event
        /// </summary>
        [JsonProperty("EventID")]
        int EventId { get; }
        /// <summary>
        /// Gets a timestamp when event was occurred relative to game start
        /// </summary>
        [JsonProperty("EventTime"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        TimeSpan EventTime { get; }
        /// <summary>
        /// Gets a type of event
        /// </summary>
        [JsonProperty("EventName")]
        LeagueGameEventType EventType { get; }
    }
}
