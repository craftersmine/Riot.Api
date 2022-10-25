using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a currently selected runes in game for participant in League of Legends game
    /// </summary>
    public class LeagueCurrentGameParticipantRuneData
    {
        /// <summary>
        /// Gets a selected participant's rune IDs
        /// </summary>
        [JsonProperty("oerkIds")]
        public int[] RuneIds { get; private set; }
        /// <summary>
        /// Gets a main rune branch type ID (ex. Resolve, Domination, etc.)
        /// </summary>
        [JsonProperty("perkStyle")]
        public int RuneMainTypeId { get; private set; }
        /// <summary>
        /// Gets a secondary rune branch type ID (ex. Resolve, Domination, etc.)
        /// </summary>
        [JsonProperty("perkSubStyle")]
        public int RuneSecondaryTypeId { get; private set; }
    }
}
