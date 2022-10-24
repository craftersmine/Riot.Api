using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends tournament event type
    /// </summary>
    public enum LeagueTournamentEventType
    {
        /// <summary>
        /// When practice tournament game created
        /// </summary>
        PracticeGameCreated,
        /// <summary>
        /// When player joined the tournament lobby
        /// </summary>
        PlayerJoinedGame,
        /// <summary>
        /// When player switched tournament team in lobby
        /// </summary>
        PlayerSwitchedTeam,
        /// <summary>
        /// When player quit tournament lobby
        /// </summary>
        PlayerQuitGame,
        /// <summary>
        /// When champion select started
        /// </summary>
        ChampionSelectStarted,
        /// <summary>
        /// When game allocation started to LSM
        /// </summary>
        GameAllocationStarted,
        /// <summary>
        /// When game allocated to LSM
        /// </summary>
        GameAllocatedToLsm
    }

    /// <summary>
    /// Contains static extensions methods for <see cref="LeagueTournamentEventType"/>
    /// </summary>
    public static class LeagueTournamentEventTypeExtensions
    {
        private const string PracticeGameCreatedEvent = "PracticeGameCreatedEvent";
        private const string PlayerJoinedGameEvent = "PlayerJoinedGameEvent";
        private const string PlayerSwitchedTeamEvent = "PlayerSwitchedTeamEvent";
        private const string PlayerQuitGameEvent = "PlayerQuitGameEvent";
        private const string ChampSelectStartedEvent = "ChampSelectStartedEvent";
        private const string GameAllocationStartedEvent = "GameAllocationStartedEvent";
        private const string GameAllocatedToLsmEvent = "GameAllocatedToLsmEvent";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueTournamentEventType"/> value
        /// </summary>
        /// <param name="eventType"><see cref="LeagueTournamentEventType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueTournamentEventType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value for <see cref="LeagueTournamentEventType"/> is selected</exception>
        public static string GetStringFor(this LeagueTournamentEventType eventType)
        {
            switch (eventType)
            {
                case LeagueTournamentEventType.PracticeGameCreated:
                    return PracticeGameCreatedEvent;
                case LeagueTournamentEventType.PlayerJoinedGame:
                    return PlayerJoinedGameEvent;
                case LeagueTournamentEventType.PlayerSwitchedTeam:
                    return PlayerSwitchedTeamEvent;
                case LeagueTournamentEventType.PlayerQuitGame:
                    return PlayerQuitGameEvent;
                case LeagueTournamentEventType.ChampionSelectStarted:
                    return ChampSelectStartedEvent;
                case LeagueTournamentEventType.GameAllocationStarted:
                    return GameAllocationStartedEvent;
                case LeagueTournamentEventType.GameAllocatedToLsm:
                    return GameAllocatedToLsmEvent;
                default:
                    throw new ArgumentException("Unknown value selected for event type", nameof(eventType));
            }
        }

        internal static LeagueTournamentEventType GetLeagueTournamentEventTypeFromString(this string str)
        {
            switch (str)
            {
                case PracticeGameCreatedEvent:
                    return LeagueTournamentEventType.PracticeGameCreated;
                case PlayerJoinedGameEvent:
                    return LeagueTournamentEventType.PlayerJoinedGame;
                case PlayerSwitchedTeamEvent:
                    return LeagueTournamentEventType.PlayerSwitchedTeam;
                case PlayerQuitGameEvent:
                    return LeagueTournamentEventType.PlayerQuitGame;
                case ChampSelectStartedEvent:
                    return LeagueTournamentEventType.ChampionSelectStarted;
                case GameAllocationStartedEvent:
                    return LeagueTournamentEventType.GameAllocationStarted;
                case GameAllocatedToLsmEvent:
                    return LeagueTournamentEventType.GameAllocatedToLsm;
                default:
                    throw new ArgumentException("Unknown value is specified for tournament event type: " + str,
                        nameof(str));
            }
        }
    }
}
