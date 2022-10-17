using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a Riot Data Platform to fetch data from
    /// </summary>
    public enum RiotPlatform
    {
        /// <summary>
        /// Brazil region
        /// </summary>
        Brazil,
        /// <summary>
        /// Europe Nordic and East region
        /// </summary>
        EuropeNordicEast,
        /// <summary>
        /// Europe West region
        /// </summary>
        EuropeWest,
        /// <summary>
        /// Latin America North region
        /// </summary>
        LatinAmericaNorth,
        /// <summary>
        /// Latin America South region
        /// </summary>
        LatinAmericaSouth,
        /// <summary>
        /// North America region
        /// </summary>
        NorthAmerica,
        /// <summary>
        /// Oceania region
        /// </summary>
        Oceania,
        /// <summary>
        /// CIS region
        /// </summary>
        Russia,
        /// <summary>
        /// Turkey region
        /// </summary>
        Turkey,
        /// <summary>
        /// Japan region
        /// </summary>
        Japan,
        /// <summary>
        /// Republic of Korea region
        /// </summary>
        Korea,
    }

    /// <summary>
    /// Contains a static methods for <see cref="RiotPlatform"/> enum extensions
    /// </summary>
    public static class RiotPlatformExtensions
    {
        /// <summary>
        /// Gets corresponding base address for platform value
        /// </summary>
        /// <param name="platform">Data Platform</param>
        /// <returns></returns>
        /// <exception cref="Exception">Should not happen</exception>
        public static string GetAddressFor(this RiotPlatform platform)
        {
            switch (platform)
            {
                case RiotPlatform.Brazil:
                    return Constants.BaseAddressPlatformBr1;
                case RiotPlatform.EuropeNordicEast:
                    return Constants.BaseAddressPlatformEun1;
                case RiotPlatform.EuropeWest:
                    return Constants.BaseAddressPlatformEuw1;
                case RiotPlatform.LatinAmericaNorth:
                    return Constants.BaseAddressPlatformLa1;
                case RiotPlatform.LatinAmericaSouth:
                    return Constants.BaseAddressPlatformLa2;
                case RiotPlatform.NorthAmerica:
                    return Constants.BaseAddressPlatformNa1;
                case RiotPlatform.Oceania:
                    return Constants.BaseAddressPlatformOc1;
                case RiotPlatform.Russia:
                    return Constants.BaseAddressPlatformRu;
                case RiotPlatform.Turkey:
                    return Constants.BaseAddressPlatformTr1;
                case RiotPlatform.Japan:
                    return Constants.BaseAddressPlatformJp1;
                case RiotPlatform.Korea:
                    return Constants.BaseAddressPlatformKr;
                default:
                    throw new Exception("Something went wrong when selecting platform! This should not happen");
            }
        }

        /// <summary>
        /// Returns an corresponding string for <see cref="RiotPlatform"/>
        /// </summary>
        /// <param name="platform"><see cref="RiotPlatform"/></param>
        /// <exception cref="ArgumentException">Should not happen</exception>
        public static string GetRiotPlatformString(this RiotPlatform platform)
        {
            switch (platform)
            {
                case RiotPlatform.Brazil:
                    return Constants.LolBrRegion;
                case RiotPlatform.EuropeNordicEast:
                    return Constants.LolEuneRegion;
                case RiotPlatform.EuropeWest:
                    return Constants.LolEuwRegion;
                case RiotPlatform.LatinAmericaNorth:
                    return Constants.LolLanRegion;
                case RiotPlatform.LatinAmericaSouth:
                    return Constants.LolLasRegion;
                case RiotPlatform.NorthAmerica:
                    return Constants.LolNaRegion;
                case RiotPlatform.Oceania:
                    return Constants.LolOceRegion;
                case RiotPlatform.Russia:
                    return Constants.LolRuRegion;
                case RiotPlatform.Turkey:
                    return Constants.LolTrRegion;
                case RiotPlatform.Japan:
                    return Constants.LolJpRegion;
                case RiotPlatform.Korea:
                    return Constants.LolKrRegion;
            }
            throw new ArgumentException("Unknown Riot Platform passed in!", nameof(platform));
        }

        internal static RiotPlatform GetRiotPlatformFromString(this string str)
        {
            switch (str)
            {
                case Constants.LolBrRegion:
                    return RiotPlatform.Brazil;
                case Constants.LolEuneRegion:
                    return RiotPlatform.EuropeNordicEast;
                case Constants.LolEuwRegion:
                    return RiotPlatform.EuropeWest;
                case Constants.LolLanRegion:
                    return RiotPlatform.LatinAmericaNorth;
                case Constants.LolLasRegion:
                    return RiotPlatform.LatinAmericaSouth;
                case Constants.LolNaRegion:
                    return RiotPlatform.NorthAmerica;
                case Constants.LolOceRegion:
                    return RiotPlatform.Oceania;
                case Constants.LolRuRegion:
                    return RiotPlatform.Russia;
                case Constants.LolTrRegion:
                    return RiotPlatform.Turkey;
                case Constants.LolJpRegion:
                    return RiotPlatform.Japan;
                case Constants.LolKrRegion:
                    return RiotPlatform.Korea;
                default:
                    throw new ArgumentException("Unknown Riot Platform passed in!", nameof(str));
            }
        }
    }
}
