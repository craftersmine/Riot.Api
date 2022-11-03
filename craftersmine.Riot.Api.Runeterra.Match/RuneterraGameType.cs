using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra game type
    /// </summary>
    public enum RuneterraGameType
    {
        /// <summary>
        /// Ranked game
        /// </summary>
        Ranked,
        /// <summary>
        /// Normal game
        /// </summary>
        Normal,
        /// <summary>
        /// Against the bot
        /// </summary>
        AI,
        /// <summary>
        /// Tutorial game
        /// </summary>
        Tutorial,
        /// <summary>
        /// Trial Vanilla game
        /// </summary>
        VanillaTrial,
        /// <summary>
        /// Singleton Gauntlet game
        /// </summary>
        Singleton,
        /// <summary>
        /// Standard Gauntlet game
        /// </summary>
        StandardGauntlet
    }
}
