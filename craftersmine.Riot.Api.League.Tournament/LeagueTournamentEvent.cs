using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Tournament.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends tournament event
    /// </summary>
    public class LeagueTournamentEvent
    {
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when event occurred
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixDateTimeConverter), true)]
        public DateTime Timestamp { get; private set; }
        /// <summary>
        /// Gets a type of tournament event
        /// </summary>
        [JsonProperty("eventType"), JsonConverter(typeof(LeagueTournamentEventTypeConverter))]
        public LeagueTournamentEventType EventType { get; private set; }
        /// <summary>
        /// Gets a summoner ID that caused this event
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
    }
}
