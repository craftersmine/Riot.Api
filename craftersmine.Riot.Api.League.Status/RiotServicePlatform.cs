using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a platform on which Riot Service is having issues
    /// </summary>
    [Flags]
    public enum RiotServicePlatform
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
    /// Contains static extension methods for <see cref="RiotServicePlatform"/>
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
        /// Gets corresponding string for <see cref="RiotServicePlatform"/> value
        /// </summary>
        /// <param name="platform">Riot Service maintenance status</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RiotServicePlatform"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RiotServicePlatform platform)
        {
            switch (platform)
            {
                case RiotServicePlatform.Windows:
                    return Windows;
                case RiotServicePlatform.MacOS:
                    return MacOs;
                case RiotServicePlatform.Android:
                    return Android;
                case RiotServicePlatform.IOS:
                    return Ios;
                case RiotServicePlatform.PS4:
                    return Ps4;
                case RiotServicePlatform.XboxOne:
                    return XboxOne;
                case RiotServicePlatform.Switch:
                    return Switch;
                default:
                    throw new ArgumentException("Unknown platform value is selected", nameof(platform));
            }
        }

        internal static RiotServicePlatform GetRiotServicePlatformFromString(this string str)
        {
            switch (str)
            {
                case Windows:
                    return RiotServicePlatform.Windows;
                case MacOs:
                    return RiotServicePlatform.MacOS;
                case Android:
                    return RiotServicePlatform.Android;
                case Ios:
                    return RiotServicePlatform.IOS;
                case Ps4:
                    return RiotServicePlatform.PS4;
                case XboxOne:
                    return RiotServicePlatform.XboxOne;
                case Switch:
                    return RiotServicePlatform.Switch;
                default:
                    return RiotServicePlatform.Unknown;
            }
        }
    }
}
