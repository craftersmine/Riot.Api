using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a type of League of Legends ward
    /// </summary>
    public enum WardType
    {
        /// <summary>
        /// Unknown type of ward
        /// </summary>
        Undefined,
        /// <summary>
        /// Stealth ward
        /// </summary>
        StealthWard,
        /// <summary>
        /// Control ward
        /// </summary>
        ControlWard,
        /// <summary>
        /// Farsight Alteration ward
        /// </summary>
        FarsightAlteration,
        /// <summary>
        /// Teemo mushroom
        /// </summary>
        TeemoShroom
    }

    /// <summary>
    /// Contains static extension methods for <see cref="WardType"/>
    /// </summary>
    public static class WardTypeExtensions
    {
        private const string Undefined = "UNDEFINED";
        private const string StealthWard = "YELLOW_TRINKET";
        private const string ControlWard = "CONTROL_WARD";
        private const string SightWard = "SIGHT_WARD";
        private const string TeemoShroom = "TEEMO_MUSHROOM";

        /// <summary>
        /// Gets a corresponding string for <see cref="WardType"/> value
        /// </summary>
        /// <param name="wardType">League of Legends <see cref="WardType"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for specified <see cref="WardType"/> value</returns>
        public static string GetStringFor(this WardType wardType)
        {
            switch (wardType)
            {
                case WardType.StealthWard:
                    return StealthWard;
                case WardType.ControlWard:
                    return ControlWard;
                case WardType.FarsightAlteration:
                    return SightWard;
                case WardType.TeemoShroom:
                    return TeemoShroom;
                case WardType.Undefined:
                default:
                    return Undefined;
            }
        }

        internal static WardType GetWardTypeFromString(this string str)
        {
            switch (str)
            {
                case StealthWard:
                    return WardType.StealthWard;
                case ControlWard:
                    return WardType.ControlWard;
                case SightWard:
                    return WardType.FarsightAlteration;
                case TeemoShroom:
                    return WardType.TeemoShroom;
                default:
                    return WardType.Undefined;
            }
        }
    }
}
