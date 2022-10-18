using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends multikill
    /// </summary>
    public enum LeagueMultikill
    {
        /// <summary>
        /// No one killed
        /// </summary>
        None = 0,
        /// <summary>
        /// Only one champion killed
        /// </summary>
        One = 1,
        /// <summary>
        /// Double kill (2 kills consecutively)
        /// </summary>
        DoubleKill = 2,
        /// <summary>
        /// Triple kill (3 kills consecutively)
        /// </summary>
        TripleKill = 3,
        /// <summary>
        /// Quadra kill (4 kills consecutively)
        /// </summary>
        QuadraKill = 4,
        /// <summary>
        /// Penta kill (5 kills consecutively)
        /// </summary>
        PentaKill = 5,
        /// <summary>
        /// Hexa kill (6 kills consecutively) 
        /// </summary>
        /// <remarks>
        /// Was only available in short period of time
        /// </remarks>
        HexaKill = 6,
    }
}
