using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents a League of Legends Clash Tournament
    /// </summary>
    public class LeagueClashTournament
    {
        /// <summary>
        /// Gets a Clash tournament ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets a Clash tournament theme ID
        /// </summary>
        [JsonProperty("themeId")]
        public int ThemeId { get; private set; }
        /// <summary>
        /// Gets a Clash tournament name key
        /// </summary>
        [JsonProperty("nameKey")]
        public string NameKey { get; private set; }
        /// <summary>
        /// Gets a Clash tournament secondary name key
        /// </summary>
        [JsonProperty("nameKeySecondary")]
        public string NameSecondaryKey { get; private set; }
        /// <summary>
        /// Gets a Clash tournament scheduled phases
        /// </summary>
        [JsonProperty("schedule")]
        public LeagueClashTournamentPhase[] Schedule { get; private set; }
    }
}
