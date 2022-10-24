using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends match pick type
    /// </summary>
    public enum LeaguePickType
    {
        /// <summary>
        /// Blind pick
        /// </summary>
        BlindPick,
        /// <summary>
        /// Draft pick
        /// </summary>
        Draft,
        /// <summary>
        /// All-random pick
        /// </summary>
        AllRandom,
        /// <summary>
        /// Tournament styled draft pick
        /// </summary>
        TournamentDraft
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeaguePickType"/> enum extensions
    /// </summary>
    public static class LeaguePickTypeExtensions
    {
        private const string BlindPick = "BLIND_PICK";
        private const string DraftMode = "DRAFT_MODE";
        private const string AllRandom = "ALL_RANDOM";
        private const string TournamentDraft = "TOURNAMENT_DRAFT";
        
        /// <summary>
        /// Gets a corresponding string for <see cref="LeaguePickType"/>
        /// </summary>
        /// <param name="pickType">League of Legends match pick type value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeaguePickType"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this LeaguePickType pickType)
        {
            switch (pickType)
            {
                case LeaguePickType.BlindPick:
                    return BlindPick;
                case LeaguePickType.Draft:
                    return DraftMode;
                case LeaguePickType.AllRandom:
                    return AllRandom;
                case LeaguePickType.TournamentDraft:
                    return TournamentDraft;
            }

            throw new ArgumentException("Unknown pick type selected", nameof(pickType));
        }

        internal static LeaguePickType GetLeaguePickTypeFromString(this string str)
        {
            switch (str)
            {
                case BlindPick:
                    return LeaguePickType.BlindPick;
                case DraftMode:
                    return LeaguePickType.Draft;
                case AllRandom:
                    return LeaguePickType.AllRandom;
                case TournamentDraft:
                    return LeaguePickType.TournamentDraft;
                default:
                    throw new ArgumentException("Unknown value for pick type provided: " + str, nameof(str));
            }
        }
    }
}
