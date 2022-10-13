using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public enum RiotRegion
    {
        Americas,
        Asia,
        Europe,
        Oceania,
        Esports
    }

    public static class RiotRegionExtensions
    {
        public static string GetAddressFor(this RiotRegion region)
        {
            switch (region)
            {
                case RiotRegion.Americas:
                    return Constants.BaseAddressRegionAmerica;
                case RiotRegion.Asia:
                    return Constants.BaseAddressRegionAsia;
                case RiotRegion.Europe:
                    return Constants.BaseAddressRegionEurope;
                case RiotRegion.Oceania:
                    return Constants.BaseAddressRegionSea;
                case RiotRegion.Esports:
                    return Constants.BaseAddressRegionEsports;
                default:
                    throw new Exception("Something went wrong with selecting region! This should not happen");
            }
        }
    }
}
