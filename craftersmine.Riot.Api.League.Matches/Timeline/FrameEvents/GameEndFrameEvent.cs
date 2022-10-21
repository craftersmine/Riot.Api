using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends match game end timeline frame event (nexus being destroyed or team surrender)
    /// </summary>
    public class GameEndFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a Game ID of this match
        /// </summary>
        [JsonProperty("gameId")]
        public int GameId { get; private set; }
        /// <summary>
        /// Gets a team ID which won this match
        /// </summary>
        [JsonProperty("winningTeam")]
        public int WinningTeamId { get; private set; }
        /// <summary>
        /// Gets a real world <see cref="DateTime"/> when <see cref="LeagueTimelineFrameEventType.GameEnd"/> event was created
        /// </summary>
        [JsonProperty("realTimestamp"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime RealTimestamp { get; private set; }
    }
}
