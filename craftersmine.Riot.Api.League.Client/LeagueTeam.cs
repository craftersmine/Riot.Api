using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends team
    /// </summary>
    public enum LeagueTeam
    {
        /// <summary>
        /// Team is unknown
        /// </summary>
        Unknown,
        /// <summary>
        /// Team is undetermined
        /// </summary>
        All,
        /// <summary>
        /// Team is neutral
        /// </summary>
        Neutral,
        /// <summary>
        /// Team is blue side (order)
        /// </summary>
        Order,
        /// <summary>
        /// Team is red side (chaos)
        /// </summary>
        Chaos,
        /// <summary>
        /// Team is blue side (order)
        /// </summary>
        Blue = Order,
        /// <summary>
        /// Team is red side (chaos)
        /// </summary>
        Red = Chaos
    }
}
