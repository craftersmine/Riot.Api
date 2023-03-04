using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueGameEvents
    {
        [JsonProperty("Events")]
        private LeagueGameEventCollection EventsInternal { get; set; }

        public ILeagueGameEvent[] Evts => EventsInternal.GetEvents();
    }

    #region Game events

    public class GameStartEvent : LeagueBaseGameEvent {}

    public class MinionsSpawningEvent : LeagueBaseGameEvent {}

    public class ChampionKillEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string[] Assisters { get; private set; }
        [JsonProperty]
        public string KillerName { get; private set; }
        [JsonProperty]
        public string VictimName { get; private set; }
    }

    public class FirstBloodEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string Recipient { get; private set; }
    }

    public class MultiKillEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string KillerName { get; private set; }
        [JsonProperty, JsonConverter(typeof(LeagueMultikillConverter))]
        public LeagueMultikill KillStreak { get; private set; }
    }

    public class TurretDestroyedEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string[] Assisters { get; private set; }
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
        [JsonProperty("TurretKilled")]
        public string TurretId { get; private set; }
    }

    public class FirstBrickEvent : LeagueBaseGameEvent 
    {
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
    }

    public class InhibitorDestroyedEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string[] Assisters { get; private set; }
        [JsonProperty("InhibKilled")]
        public string InhibitorId { get; private set; }
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
    }

    public class AceEvent : LeagueBaseGameEvent
    {
        [JsonProperty]
        public string Acer { get; private set; }
        [JsonProperty, JsonConverter(typeof(StringEnumConverter))]
        public LeagueTeam AcingTeam { get; private set; }
    }

    public class GameEndEvent : LeagueBaseGameEvent
    {
        // TODO(craftersmine): create result enum and converter for it
        [JsonProperty]
        public string Result { get; private set; }
    }

    #endregion
}
