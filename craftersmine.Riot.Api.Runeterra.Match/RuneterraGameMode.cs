using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra game mode
    /// </summary>
    public enum RuneterraGameMode
    {
        /// <summary>
        /// Constructed game mode
        /// </summary>
        Constructed,
        /// <summary>
        /// Expeditions game mode
        /// </summary>
        Expeditions,
        /// <summary>
        /// Tutorial game
        /// </summary>
        Tutorial
    }

    /// <summary>
    /// Contains static extension methods for <see cref="RuneterraGameMode"/>
    /// </summary>
    public static class RuneterraGameModeExtensions
    {
        private const string Constructed = "Constructed";
        private const string Expeditions = "Expeditions";
        private const string Tutorial = "Tutorial";

        /// <summary>
        /// Gets a corresponding string for specified <see cref="RuneterraGameMode"/> value
        /// </summary>
        /// <param name="gameMode">Legends of Runeterra game mode value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RuneterraGameMode"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RuneterraGameMode gameMode)
        {
            switch (gameMode)
            {
                case RuneterraGameMode.Constructed:
                    return Constructed;
                case RuneterraGameMode.Expeditions:
                    return Expeditions;
                case RuneterraGameMode.Tutorial:
                    return Tutorial;
                default:
                    throw new ArgumentException("Unknown game mode is selected", nameof(gameMode));
            }
        }

        internal static RuneterraGameMode GetRuneterraGameModeFromString(this string str)
        {
            switch (str)
            {
                case Constructed:
                    return RuneterraGameMode.Constructed;
                case Expeditions:
                    return RuneterraGameMode.Expeditions;
                case Tutorial:
                    return RuneterraGameMode.Tutorial;
                default:
                    throw new ArgumentException("Unknown game mode string provided!", nameof(str));
            }
        }
    }
}
