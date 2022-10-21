using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends match timeline ward placement frame event
    /// </summary>
    public class WardPlacedFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of participant who placed a ward
        /// </summary>
        [JsonProperty("creatorId")]
        public int CreatorId { get; private set; }
        /// <summary>
        /// Gets a type of ward that was placed
        /// </summary>
        [JsonProperty("wardType"), JsonConverter(typeof(WardTypeConverter))]
        public WardType WardType { get; private set; }
    }

    /// <summary>
    /// Represents a League of Legends match timeline ward destroyed frame event
    /// </summary>
    public class WardKilledFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an ID of participant who killed a ward
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets a type of ward that was killed
        /// </summary>
        [JsonProperty("wardType"), JsonConverter(typeof(WardTypeConverter))]
        public WardType WardType { get; private set; }
    }

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
