using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League match events information collection
    /// </summary>
    public class LeagueGameEvents
    {
        [JsonProperty("Events")]
        private LeagueGameEventCollection EventsInternal { get; set; }

        /// <summary>
        /// Gets all game events
        /// </summary>
        public ILeagueGameEvent[] GameEvents => EventsInternal.GetEvents();
        /// <summary>
        /// Gets game event by event ID
        /// </summary>
        /// <param name="id">Event ID</param>
        /// <returns>League game event</returns>
        public ILeagueGameEvent this[int id] => EventsInternal.GetEvent(id);

        /// <inheritdoc cref="this"/>
        public ILeagueGameEvent GetEvent(int id) => EventsInternal.GetEvent(id);
        /// <inheritdoc cref="GameEvents"/>
        public ILeagueGameEvent[] GetEvents() => EventsInternal.GetEvents();
    }

    #region Game events

    /// <summary>
    /// Represents a game start event
    /// </summary>
    public class GameStartEvent : LeagueBaseGameEvent {}

    /// <summary>
    /// Represents a minion spawning started event
    /// </summary>
    public class MinionsSpawningEvent : LeagueBaseGameEvent {}

    /// <summary>
    /// Represents a champion kill event
    /// </summary>
    public class ChampionKilledEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets an array of summoners name that assisted in event
        /// </summary>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets a summoner name of killer
        /// </summary>
        [JsonProperty]
        public string KillerName { get; private set; }
        /// <summary>
        /// Gets a summoner name of victim
        /// </summary>
        [JsonProperty]
        public string VictimName { get; private set; }
    }

    /// <summary>
    /// Represents a first blood event
    /// </summary>
    public class FirstBloodEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets a summoner name who performed first blood
        /// </summary>
        [JsonProperty]
        public string Recipient { get; private set; }
    }

    /// <summary>
    /// Represents a multi-kill event
    /// </summary>
    public class MultiKillEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets a summoner name who performed a multi-kill
        /// </summary>
        [JsonProperty]
        public string KillerName { get; private set; }
        /// <summary>
        /// Gets a multi-kill streak
        /// </summary>
        [JsonProperty, JsonConverter(typeof(LeagueMultikillConverter))]
        public LeagueMultikill KillStreak { get; private set; }
    }

    /// <summary>
    /// Represents a destroyed turret event
    /// </summary>
    public class TurretDestroyedEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets an array of summoner names who assisted in event
        /// </summary>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets a summoner name or entity ID who destroyed a turret
        /// </summary>
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
        /// <summary>
        /// Gets a ID of turret that was destroyed
        /// </summary>
        [JsonProperty("TurretKilled")]
        public string TurretId { get; private set; }
    }

    /// <summary>
    /// Represents a first turret destroyed event
    /// </summary>
    public class FirstBrickEvent : LeagueBaseGameEvent 
    {
        /// <inheritdoc cref="TurretDestroyedEvent.DestroyerName"/>
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
    }

    /// <summary>
    /// Represents a destroyed inhibitor event
    /// </summary>
    public class InhibitorDestroyedEvent : LeagueBaseGameEvent
    {
        /// <inheritdoc cref="TurretDestroyedEvent.Assisters"/>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets an ID of inhibitor that was destroyed
        /// </summary>
        [JsonProperty("InhibKilled")]
        public string InhibitorId { get; private set; }
        /// <inheritdoc cref="TurretDestroyedEvent.DestroyerName"/>
        [JsonProperty("KillerName")]
        public string DestroyerName { get; private set; }
    }

    /// <summary>
    /// Represents an ace event
    /// </summary>
    public class AceEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets a summoner name that made an ace
        /// </summary>
        [JsonProperty]
        public string Acer { get; private set; }
        /// <summary>
        /// Gets a League team that made an ace
        /// </summary>
        [JsonProperty, JsonConverter(typeof(StringEnumConverter))]
        public LeagueTeam AcingTeam { get; private set; }
    }

    /// <summary>
    /// Represents a killed dragon event
    /// </summary>
    public class DragonKilledEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Contains a types of dragons
        /// </summary>
        public enum DragonTypes
        {
            /// <summary>
            /// Cloud drake
            /// </summary>
            Air,
            /// <summary>
            /// Mountain drake
            /// </summary>
            Earth,
            /// <summary>
            /// Infernal drake
            /// </summary>
            Fire,
            /// <summary>
            /// Ocean drake
            /// </summary>
            Water,
            /// <summary>
            /// Hextech drake
            /// </summary>
            Hextech,
            /// <summary>
            /// Chemtech drake
            /// </summary>
            Chemtech,
            /// <summary>
            /// Elder drake
            /// </summary>
            Elder,

            /// <inheritdoc cref="Air"/>
            Cloud = Air,
            /// <inheritdoc cref="Mountain"/>
            Mountain = Earth,
            /// <inheritdoc cref="Fire"/>
            Infernal = Fire,
            /// <inheritdoc cref="Water"/>
            Ocean = Water,
        }

        /// <summary>
        /// Gets an array of summoners names that assisted in event
        /// </summary>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets a type of killed dragon
        /// </summary>
        [JsonProperty]
        public DragonTypes DragonType { get; private set; }
        /// <summary>
        /// Gets a summoner name who killed dragon
        /// </summary>
        [JsonProperty]
        public string KillerName { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if dragon was stolen from team
        /// </summary>
        [JsonProperty("Stolen")]
        public bool IsStolen { get; private set; }
    }

    /// <summary>
    /// Represents a killed herald event
    /// </summary>
    public class HeraldKilledEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets an array of summoner names that assisted in event
        /// </summary>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets a summoner name who killed herald
        /// </summary>
        [JsonProperty]
        public string KillerName { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if herald was stolen from team
        /// </summary>
        [JsonProperty("Stolen")]
        public bool IsStolen { get; private set; }
    }

    /// <summary>
    /// Represents a killed baron event
    /// </summary>
    public class BaronKilledEvent : LeagueBaseGameEvent
    {
        /// <summary>
        /// Gets an array of summoner names that assisted in event
        /// </summary>
        [JsonProperty]
        public string[] Assisters { get; private set; }
        /// <summary>
        /// Gets a summoner name who killed baron
        /// </summary>
        [JsonProperty]
        public string KillerName { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if baron was stolen from team
        /// </summary>
        [JsonProperty("Stolen")]
        public bool IsStolen { get; private set; }
    }

    /// <summary>
    /// Represents a game end event
    /// </summary>
    public class GameEndEvent : LeagueBaseGameEvent
    {
        // TODO(craftersmine): create result enum and converter for it
        /// <summary>
        /// Gets a game end result for a team
        /// </summary>
        [JsonProperty]
        public string Result { get; private set; }
    }

    #endregion
}
