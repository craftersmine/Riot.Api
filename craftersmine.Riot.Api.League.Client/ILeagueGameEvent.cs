using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    internal interface ILeagueGameEvent
    {
        int EventId { get; }
        TimeSpan EventTime { get; }
        LeagueGameEventType EventType { get; }
    }
}
