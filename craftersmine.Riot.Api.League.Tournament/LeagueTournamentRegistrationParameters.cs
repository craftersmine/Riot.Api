using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament
{
    /// <summary>
    /// Represents a League of Legends Tournament registration parameters
    /// </summary>
    public class LeagueTournamentRegistrationParameters
    {
        /// <summary>
        /// Gets or sets a Tournament name
        /// </summary>
        [JsonProperty("name")]
        public string TournamentName { get; set; }
        /// <summary>
        /// Gets or sets a Tournament provider ID
        /// </summary>
        [JsonProperty("providerId")]
        public int ProviderId { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="LeagueTournamentRegistrationParameters"/>
        /// </summary>
        /// <param name="tournamentName">Tournament name</param>
        /// <param name="providerId">Tournament provider ID</param>
        public LeagueTournamentRegistrationParameters(string tournamentName, int providerId)
        {
            TournamentName = tournamentName;
            ProviderId = providerId;
        }
    }
}
