using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends Tournament parameters
    /// </summary>
    public class LeagueTournamentCodeParameters : LeagueTournamentCodeUpdateParameters
    {
        private int teamSize = 1;

        /// <summary>
        /// Gets or sets custom string of data for tournament provider. Can be used for additional custom information or can be left empty
        /// </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        /// <summary>
        /// Gets or sets a team size for tournament
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">When team size is less than 1 or more than 5</exception>
        [JsonProperty("teamSize")]
        public int TeamSize
        {
            get => teamSize;
            set
            {
                if (value >= 1 && value <= 5)
                    teamSize = value;
                throw new ArgumentOutOfRangeException(nameof(TeamSize),
                    $"Team size cannot have {value} amount of participants, valid size is ranged from 1 to 5");
            }
        }
        
        /// <summary>
        /// Creates a new instance of <see cref="LeagueTournamentCodeParameters"/>
        /// </summary>
        /// <param name="allowedSummonerIds">An array of summoners IDs in order to validate if the players are eligible to join the lobby, or <see langword="null"/></param>
        /// <param name="pickType">Champion pick type</param>
        /// <param name="mapType">Map type</param>
        /// <param name="spectatorType">Spectators type</param>
        /// <param name="teamSize">Size of each team</param>
        /// <exception cref="ArgumentOutOfRangeException">When team size is less than 1 or more than 5</exception>
        public LeagueTournamentCodeParameters(string[] allowedSummonerIds, LeaguePickType pickType, LeagueMapType mapType, LeagueSpectatorType spectatorType, int teamSize) : base(allowedSummonerIds, pickType, mapType, spectatorType)
        {
            TeamSize = teamSize;
        }
    }
}
