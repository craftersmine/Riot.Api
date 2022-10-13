using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public enum RiotPlatform
    {
        Brazil,
        EuropeNordicEast,
        EuropeWest,
        LatinAmericaNorth,
        LatinAmericaSouth,
        NorthAmerica,
        Oceania,
        Russia,
        Turkey,
        Japan,
        Korea,
    }

    public static class RiotPlatformExtensions
    {
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
    }
}
