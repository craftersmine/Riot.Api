using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents Teamfight Tactics trait style
    /// </summary>
    public enum TftTraitStyle
    {
        /// <summary>
        /// Trait has no current style
        /// </summary>
        NoStyle = 0,
        /// <summary>
        /// Trait has bronze style
        /// </summary>
        Bronze = 1,
        /// <summary>
        /// Trait has silver style
        /// </summary>
        Silver = 2,
        /// <summary>
        /// Trait has gold style
        /// </summary>
        Gold = 3,
        /// <summary>
        /// Trait has chromatic style
        /// </summary>
        Chromatic = 4
    }
}
