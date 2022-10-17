using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents a League of Legends Clash Tournament phase
    /// </summary>
    public class LeagueClashTournamentPhase
    {
        /// <summary>
        /// Gets a Clash tournament phase ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if Clash tournament phase was cancelled
        /// </summary>
        [JsonProperty("cancelled")]
        public bool IsCancelled { get; private set; }
        /// <summary>
        /// Gets a Clash tournament registration opening <see cref="DateTime"/>
        /// </summary>
        [JsonProperty("registrationTime"), JsonConverter(typeof(Common.Converters.UnixDateTimeConverter))]
        public DateTime RegistrationTime { get; private set; }
        /// <summary>
        /// Gets a Clash tournament starting <see cref="DateTime"/>
        /// </summary>
        [JsonProperty("startTime"), JsonConverter(typeof(Common.Converters.UnixDateTimeConverter))]
        public DateTime StartTime { get; private set; }
    }
}
