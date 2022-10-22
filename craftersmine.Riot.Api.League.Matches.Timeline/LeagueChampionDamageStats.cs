using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends champion damage stats
    /// </summary>
    public class LeagueChampionDamageStats
    {
        /// <summary>
        /// Gets a total amount of magic damage done by champion
        /// </summary>
        [JsonProperty("magicDamageDone")]
        public int MagicDamageDone { get; private set; }
        /// <summary>
        /// Gets a total amount of magic damage done by champion to champions alone
        /// </summary>
        [JsonProperty("magicDamageDoneToChampions")]
        public int MagicDamageDoneToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of magic damage taken by champion
        /// </summary>
        [JsonProperty("magicDamageTaken")]
        public int MagicDamageTaken { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage done by champion
        /// </summary>
        [JsonProperty("physicalDamageDone")]
        public int PhysicalDamageDone { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage done by champion to champions alone
        /// </summary>
        [JsonProperty("physicalDamageDoneToChampions")]
        public int PhysicalDamageDoneToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage taken by champion
        /// </summary>
        [JsonProperty("physicalDamageTaken")]
        public int PhysicalDamageTaken { get; private set; }
        /// <summary>
        /// Gets a total amount of damage done by champion (physical + magic + true damage)
        /// </summary>
        [JsonProperty("totalDamageDon")]
        public int TotalDamageDone { get; private set; }
        /// <summary>
        /// Gets a total amount of damage done by champion to champions alone (physical + magic + true damage)
        /// </summary>
        [JsonProperty("totalDamageDoneToChampions")]
        public int TotalDamageDoneToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage done by champion
        /// </summary>
        [JsonProperty("trueDamageDone")]
        public int TrueDamageDone { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage done by champion to champions alone
        /// </summary>
        [JsonProperty("trueDamageDoneToChampions")]
        public int TrueDamageDoneToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage taken by champion
        /// </summary>
        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; private set; }
    }
}
