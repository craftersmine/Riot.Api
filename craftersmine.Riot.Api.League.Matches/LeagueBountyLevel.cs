using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends champion bounty level
    /// </summary>
    public enum LeagueBountyLevel
    {
        /// <summary>
        /// Champion had no bounty level
        /// </summary>
        None = 0,
        /// <summary>
        /// Champion killed one champion
        /// </summary>
        OneKill = 1,
        /// <summary>
        /// Champion killed two champions (150G bounty)
        /// </summary>
        TwoKills = 2,
        /// <summary>
        /// Champion is on killing spree (3 killed champions - 300G bounty)
        /// </summary>
        KillingSpree = 3,
        /// <summary>
        /// Champion is on rampage (FOUR! killed champions - 400G bounty)
        /// </summary>
        Rampage = 4,
        /// <summary>
        /// Champion is unstoppable (5 killed champions - 500G bounty)
        /// </summary>
        Unstoppable = 5,
        /// <summary>
        /// Champion is dominating (6 killed champions - 600G bounty)
        /// </summary>
        Dominating = 6,
        /// <summary>
        /// Champion is Godlike (6 killed champions - 700G bounty)
        /// </summary>
        Godlike = 7,
        /// <summary>
        /// Champion is Legendary
        /// </summary> (8 or more killed champions - 700G bounty + 100G for every consecutive next kill)
        Legendary = 8,
        /// <summary>
        /// Champion had one consecutive death
        /// </summary>
        OneConsecutiveDeath = -1,
        /// <summary>
        /// Champion had two consecutive deaths
        /// </summary>
        TwoConsecutiveDeaths = -2,
        /// <summary>
        /// Champion had three consecutive deaths
        /// </summary>
        ThreeConsecutiveDeaths = -3,
        /// <summary>
        /// Champion had four consecutive deaths
        /// </summary>
        FourConsecutiveDeaths = -4,
        /// <summary>
        /// Champion had five consecutive deaths
        /// </summary>
        FiveConsecutiveDeaths = -5,
        /// <summary>
        /// Champion had six or more consecutive deaths
        /// </summary>
        SixAndBeyondConsecutiveDeaths = -6,

        /// <inheritdoc cref="None"/>
        G0Level0 = None,
        /// <inheritdoc cref="OneKill"/>
        G0Level1 = OneKill,
        /// <inheritdoc cref="TwoKills"/>
        G150 = TwoKills,
        /// <inheritdoc cref="KillingSpree"/>
        G300 = KillingSpree,
        /// <inheritdoc cref="Rampage"/>
        G400 = Rampage,
        /// <inheritdoc cref="Unstoppable"/>
        G500 = Unstoppable,
        /// <inheritdoc cref="Dominating"/>
        G600 = Dominating,
        /// <inheritdoc cref="Godlike"/>
        G700 = Godlike,
        /// <inheritdoc cref="Legendary"/>
        G700Plus100PerLevel = Legendary,
        
        /// <inheritdoc cref="OneConsecutiveDeath"/>
        KillWorth274G = OneConsecutiveDeath,
        /// <inheritdoc cref="TwoConsecutiveDeaths"/>
        KillWorth220G = TwoConsecutiveDeaths,
        /// <inheritdoc cref="ThreeConsecutiveDeaths"/>
        KillWorth176G = ThreeConsecutiveDeaths,
        /// <inheritdoc cref="FourConsecutiveDeaths"/>
        KillWorth140G = FourConsecutiveDeaths,
        /// <inheritdoc cref="FiveConsecutiveDeaths"/>
        KillWorth112G = FiveConsecutiveDeaths,
        /// <inheritdoc cref="SixAndBeyondConsecutiveDeaths"/>
        KillWorth100G = SixAndBeyondConsecutiveDeaths,

        /// <summary>
        /// "FOUR!" - Jhin
        /// </summary>
        FOUR = Rampage
    }
}
