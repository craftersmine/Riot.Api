using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents Teamfight Tactics unit tier
    /// </summary>
    public enum TftUnitTier
    {
        /// <summary>
        /// Tier is unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Unit has no tier
        /// </summary>
        Default = 1,
        /// <summary>
        /// Unit has two stars
        /// </summary>
        TwoStars = 2,
        /// <summary>
        /// Unit has three stars
        /// </summary>
        ThreeStars = 3,
    }
}
