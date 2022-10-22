using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a bitmask for Riot Service status publish locations
    /// </summary>
    [Flags]
    public enum RiotServiceStatusPublishLocations
    {
        /// <summary>
        /// Unknown publish location
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Service related Game
        /// </summary>
        Game = 1,
        /// <summary>
        /// Riot Games Client
        /// </summary>
        RiotClient = 2,
        /// <summary>
        /// Riot Games Services Status page
        /// </summary>
        RiotStatus = 4
    }
    
    /// <summary>
    /// Contains static extension methods for <see cref="RiotServiceStatusPublishLocations"/>
    /// </summary>
    public static class RiotServiceStatusPublishLocationsExtensions
    {
        private const string Game = "game";
        private const string RiotClient = "riotclient";
        private const string RiotStatus = "riotstatus";
        
        /// <summary>
        /// Gets corresponding string for <see cref="RiotServiceStatusPublishLocations"/> value
        /// </summary>
        /// <param name="publishLocations">Riot Service maintenance status</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RiotServiceStatusPublishLocations"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RiotServiceStatusPublishLocations publishLocations)
        {
            switch (publishLocations)
            {
                case RiotServiceStatusPublishLocations.Game:
                    return Game;
                case RiotServiceStatusPublishLocations.RiotClient:
                    return RiotClient;
                case RiotServiceStatusPublishLocations.RiotStatus:
                    return RiotStatus;
                default:
                    throw new ArgumentException("Unknown publish location value is selected", nameof(publishLocations));
            }
        }

        internal static RiotServiceStatusPublishLocations GetRiotServiceStatusPublishLocationsFromString(
            this string str)
        {
            switch (str)
            {
                case Game:
                    return RiotServiceStatusPublishLocations.Game;
                case RiotClient:
                    return RiotServiceStatusPublishLocations.RiotClient;
                case RiotStatus:
                    return RiotServiceStatusPublishLocations.RiotStatus;
                default:
                    return RiotServiceStatusPublishLocations.Unknown;
            }
        }
    }
}
