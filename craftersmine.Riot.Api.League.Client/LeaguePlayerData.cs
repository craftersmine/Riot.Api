using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends game participant information
    /// </summary>
    public class LeaguePlayerData
    {
        /// <summary>
        /// Gets player's champion level
        /// </summary>
        [JsonProperty("level")]
        public int ChampionLevel { get; private set; }
        /// <summary>
        /// Gets player's champion skin ID
        /// </summary>
        [JsonProperty("skinID")]
        public int SkinId { get; private set; } // skin id (chromas are separate skin internally)
        /// <summary>
        /// Gets <see langword="true"/> if this player is bot, otherwise <see langword="false"/>
        /// </summary>
        [JsonProperty("isBot")]
        public bool IsBot { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this player is currently dead, otherwise <see langword="false"/>
        /// </summary>
        [JsonProperty("isDead")]
        public bool IsDead { get; private set; }
        /// <summary>
        /// Gets player's base champion name
        /// </summary>
        [JsonProperty("championName")]
        public string ChampionName { get; private set; }
        /// <summary>
        /// Gets player's position
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; private set; } // TODO (craftersmine): Determine what it is (what lane is it actually, preselected in client or generated)
        /// <summary>
        /// Gets an internal raw champion raw name
        /// </summary>
        [JsonProperty("rawChampionName")]
        public string RawChampionName { get; private set; }
        /// <summary>
        /// Gets an internal raw champion skin name
        /// </summary>
        [JsonProperty("rawSkinName")]
        public string RawSkinName { get; private set; }
        /// <summary>
        /// Gets player's champion skin name
        /// </summary>
        [JsonProperty("skinName")]
        public string SkinName { get; private set; }
        /// <summary>
        /// Gets player's summoner name
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }
        /// <summary>
        /// Gets player's team
        /// </summary>
        [JsonProperty("team"), JsonConverter(typeof(StringEnumConverter))]
        public LeagueTeam Team { get; private set; }
        /// <summary>
        /// Gets <see cref="TimeSpan"/> of how long player will remain dead until respawn
        /// </summary>
        [JsonProperty("respawnTimer"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan RespawnTimer { get; private set; }
        /// <summary>
        /// Gets an array of player's current items
        /// </summary>
        [JsonProperty("items")]
        public LeagueItem[] Items { get; private set; }
        /// <summary>
        /// Gets player's rune set
        /// </summary>
        [JsonProperty("runes")]
        public LeagueChampionRunes Runes { get; private set; }
        /// <summary>
        /// Gets player's current scores
        /// </summary>
        [JsonProperty("scores")]
        public LeagueScores Scores { get; private set; }
        /// <summary>
        /// Gets player's summoner spell set
        /// </summary>
        [JsonProperty("summonerSpells")]
        public LeaguePlayerSummonerSpells SummonerSpells { get; private set; }
    }
}
