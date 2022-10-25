using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a participant in current League of Legends game
    /// </summary>
    public class LeagueCurrentGameParticipant
    {
        /// <summary>
        /// Gets a participant team ID
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets a participant's summoner spell ID in first slot ([D] key)
        /// </summary>
        [JsonProperty("spell1Id")]
        public int SummonerSpell1Id { get; private set; }
        /// <summary>
        /// Gets a participant's summoner spell ID in second slot ([F] key)
        /// </summary>
        [JsonProperty("spell2Id")]
        public int SummonerSpell2Id { get; private set; }
        /// <summary>
        /// Gets a participant's champion ID
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
        /// <summary>
        /// Gets a participant's profile icon ID
        /// </summary>
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant is bot
        /// </summary>
        [JsonProperty("bot")]
        public bool IsBot { get; private set; }
        /// <summary>
        /// Gets a participant's summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets a participant's League Encrypted Summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets an array of current participant's game customizations
        /// </summary>
        [JsonProperty("gameCustomizationObjects")]
        public LeagueCurrentGameCustomizationObject[] CustomizationObjects { get; private set; }
        /// <summary>
        /// Gets a participant's current selected runes
        /// </summary>
        [JsonProperty("perks")]
        public LeagueCurrentGameParticipantRuneData RuneData { get; private set; }
    }
}
