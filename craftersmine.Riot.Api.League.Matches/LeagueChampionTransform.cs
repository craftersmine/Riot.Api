using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends champion transformation form
    /// </summary>
    /// <remarks>
    ///  Currently used only for Kayn
    /// </remarks>
    public enum LeagueChampionTransform
    {
        /// <summary>
        /// No transformation performed
        /// </summary>
        None = 0,
        /// <summary>
        /// Champion transformed into slayer form
        /// </summary>
        Slayer = 1,
        /// <summary>
        /// Champion transformed into assassin form
        /// </summary>
        Assassin = 2,

        /// <summary>
        /// Player transformed Kayn into Rhaast
        /// </summary>
        Rhaast = Slayer,
        /// <summary>
        /// Player transformed Kayn into Shadow Assassin
        /// </summary>
        BlueKayn = Assassin
    }
}
