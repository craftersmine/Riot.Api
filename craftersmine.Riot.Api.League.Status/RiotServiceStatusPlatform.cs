using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a bitmask of platforms on which Riot Service is having issues
    /// </summary>
    [Flags]
    public enum RiotServiceStatusPlatform
    {
        /// <summary>
        /// Unknown platform
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Microsoft Windows
        /// </summary>
        Windows = 1,
        /// <summary>
        /// Apple macOS
        /// </summary>
        MacOS = 2,
        /// <summary>
        /// Google Android devices
        /// </summary>
        Android = 4,
        /// <summary>
        /// Apple iOS devices
        /// </summary>
        IOS = 8,
        /// <summary>
        /// Sony PlayStation 4/5
        /// </summary>
        PS4 = 16,
        /// <summary>
        /// Microsoft Xbox One/Series
        /// </summary>
        XboxOne = 32,
        /// <summary>
        /// Nintendo Switch
        /// </summary>
        Switch = 64
    }
    
    /// <summary>
    /// Contains static extension methods for <see cref="RiotServiceStatusPlatform"/>
    /// </summary>
    public static class RiotServicePlatformExtensions
    {
        private const string Windows = "windows";
        private const string MacOs = "macos";
        private const string Android = "android";
        private const string Ios = "ios";
        private const string Ps4 = "ps4";
        private const string XboxOne = "xbone";
        private const string Switch = "switch";
        
        /// <summary>
        /// Gets corresponding string for <see cref="RiotServiceStatusPlatform"/> value
        /// </summary>
        /// <param name="platform">Riot Service maintenance status</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RiotServiceStatusPlatform"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RiotServiceStatusPlatform platform)
        {
            switch (platform)
            {
                case RiotServiceStatusPlatform.Windows:
                    return Windows;
                case RiotServiceStatusPlatform.MacOS:
                    return MacOs;
                case RiotServiceStatusPlatform.Android:
                    return Android;
                case RiotServiceStatusPlatform.IOS:
                    return Ios;
                case RiotServiceStatusPlatform.PS4:
                    return Ps4;
                case RiotServiceStatusPlatform.XboxOne:
                    return XboxOne;
                case RiotServiceStatusPlatform.Switch:
                    return Switch;
                default:
                    throw new ArgumentException("Unknown platform value is selected", nameof(platform));
            }
        }

        internal static RiotServiceStatusPlatform GetRiotServicePlatformFromString(this string str)
        {
            switch (str)
            {
                case Windows:
                    return RiotServiceStatusPlatform.Windows;
                case MacOs:
                    return RiotServiceStatusPlatform.MacOS;
                case Android:
                    return RiotServiceStatusPlatform.Android;
                case Ios:
                    return RiotServiceStatusPlatform.IOS;
                case Ps4:
                    return RiotServiceStatusPlatform.PS4;
                case XboxOne:
                    return RiotServiceStatusPlatform.XboxOne;
                case Switch:
                    return RiotServiceStatusPlatform.Switch;
                default:
                    return RiotServiceStatusPlatform.Unknown;
            }
        }
    }
}
