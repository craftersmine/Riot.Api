using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends or Runeterra game outcome
    /// </summary>
    public enum RuneterraGameOutcome
    {
        /// <summary>
        /// Player won the game
        /// </summary>
        Win,
        /// <summary>
        /// Player lost the game
        /// </summary>
        Loss,
        /// <summary>
        /// Players end up in tie
        /// </summary>
        Tie
    }
}
