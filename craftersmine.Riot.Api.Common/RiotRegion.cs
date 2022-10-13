using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a Riot Data Region to fetch data
    /// </summary>
    public enum RiotRegion
    {
        /// <summary>
        /// North and South America regions
        /// </summary>
        Americas,
        /// <summary>
        /// Asian regions
        /// </summary>
        Asia,
        /// <summary>
        /// European and CIS regions
        /// </summary>
        Europe,
        /// <summary>
        /// Oceanic regions
        /// </summary>
        Oceania,
        /// <summary>
        /// Esports data region
        /// </summary>
        Esports
    }

    public static class RiotRegionExtensions
    {
        /// <summary>
        /// Gets corresponding base address for region value
        /// </summary>
        /// <param name="region">Region value</param>
        /// <returns></returns>
        /// <exception cref="Exception">Should not happen</exception>
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
