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
        /// <summary>
        /// Philippines region
        /// </summary>
        Philippines,
        /// <summary>
        /// Singapore, Malaysia, & Indonesia region
        /// </summary>
        Singapore,
        /// <summary>
        /// Thailand region
        /// </summary>
        Thailand,
        /// <summary>
        /// Vietnam region
        /// </summary>
        Vietnam,
        /// <summary>
        /// Taiwan region
        /// </summary>
        Taiwan
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
                case RiotPlatform.Philippines:
                    return Constants.BaseAddressPlatformPh2;
                case RiotPlatform.Singapore:
                    return Constants.BaseAddressPlatformSg2;
                case RiotPlatform.Thailand:
                    return Constants.BaseAddressPlatformTh2;
                case RiotPlatform.Vietnam:
                    return Constants.BaseAddressPlatformVn2;
                case RiotPlatform.Taiwan:
                    return Constants.BaseAddressPlatformTw2;
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
                    return Constants.LolBr1Region;
                case RiotPlatform.EuropeNordicEast:
                    return Constants.LolEun1Region;
                case RiotPlatform.EuropeWest:
                    return Constants.LolEuw1Region;
                case RiotPlatform.LatinAmericaNorth:
                    return Constants.LolLa1Region;
                case RiotPlatform.LatinAmericaSouth:
                    return Constants.LolLa2Region;
                case RiotPlatform.NorthAmerica:
                    return Constants.LolNa1Region;
                case RiotPlatform.Oceania:
                    return Constants.LolOc1Region;
                case RiotPlatform.Russia:
                    return Constants.LolRuRegion;
                case RiotPlatform.Turkey:
                    return Constants.LolTr1Region;
                case RiotPlatform.Japan:
                    return Constants.LolJp1Region;
                case RiotPlatform.Korea:
                    return Constants.LolKrRegion;
                case RiotPlatform.Philippines:
                    return Constants.LolPh2Region;
                case RiotPlatform.Singapore:
                    return Constants.LolSg2Region;
                case RiotPlatform.Thailand:
                    return Constants.LolTh2Region;
                case RiotPlatform.Taiwan:
                    return Constants.LolTw2Region;
                case RiotPlatform.Vietnam:
                    return Constants.LolVn2Region;
            }
            throw new ArgumentException("Unknown Riot Platform passed in!", nameof(platform));
        }

        internal static RiotPlatform GetRiotPlatformFromString(this string str)
        {
            switch (str)
            {
                case Constants.LolBr1Region:
                    return RiotPlatform.Brazil;
                case Constants.LolEun1Region:
                    return RiotPlatform.EuropeNordicEast;
                case Constants.LolEuw1Region:
                    return RiotPlatform.EuropeWest;
                case Constants.LolLa1Region:
                    return RiotPlatform.LatinAmericaNorth;
                case Constants.LolLa2Region:
                    return RiotPlatform.LatinAmericaSouth;
                case Constants.LolNa1Region:
                    return RiotPlatform.NorthAmerica;
                case Constants.LolOc1Region:
                    return RiotPlatform.Oceania;
                case Constants.LolRuRegion:
                    return RiotPlatform.Russia;
                case Constants.LolTr1Region:
                    return RiotPlatform.Turkey;
                case Constants.LolJp1Region:
                    return RiotPlatform.Japan;
                case Constants.LolKrRegion:
                    return RiotPlatform.Korea;
                case Constants.LolPh2Region:
                    return RiotPlatform.Philippines;
                case Constants.LolSg2Region:
                    return RiotPlatform.Singapore;
                case Constants.LolTh2Region:
                    return RiotPlatform.Thailand;
                case Constants.LolTw2Region:
                    return RiotPlatform.Taiwan;
                case Constants.LolVn2Region:
                    return RiotPlatform.Vietnam;
                default:
                    throw new ArgumentException("Unknown Riot Platform passed in!", nameof(str));
            }
        }

        /// <summary>
        /// Returns an corresponding full string for <see cref="RiotPlatform"/>
        /// </summary>
        /// <param name="platform"><see cref="RiotPlatform"/></param>
        /// <exception cref="ArgumentException">Should not happen</exception>
        public static string GetRiotPlatformFullString(this RiotPlatform platform)
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
                case RiotPlatform.Philippines:
                    return Constants.LolPhRegion;
                case RiotPlatform.Singapore:
                    return Constants.LolSgRegion;
                case RiotPlatform.Thailand:
                    return Constants.LolThRegion;
                case RiotPlatform.Taiwan:
                    return Constants.LolTwRegion;
                case RiotPlatform.Vietnam:
                    return Constants.LolVnRegion;
            }
            throw new ArgumentException("Unknown Riot Platform passed in!", nameof(platform));
        }

        internal static RiotPlatform GetRiotPlatformFromFullString(this string str)
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
                case Constants.LolPhRegion:
                    return RiotPlatform.Philippines;
                case Constants.LolSgRegion:
                    return RiotPlatform.Singapore;
                case Constants.LolThRegion:
                    return RiotPlatform.Thailand;
                case Constants.LolTwRegion:
                    return RiotPlatform.Taiwan;
                case Constants.LolVnRegion:
                    return RiotPlatform.Vietnam;
                default:
                    throw new ArgumentException("Unknown Riot Platform passed in!", nameof(str));
            }
        }
    }
}
