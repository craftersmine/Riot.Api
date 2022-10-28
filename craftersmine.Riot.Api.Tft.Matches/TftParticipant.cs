using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches
{
    /// <summary>
    /// Represents a Teamfight Tactics match participant
    /// </summary>
    public class TftParticipant
    {
        /// <summary>
        /// Gets a value of gold left upon game end
        /// </summary>
        [JsonProperty("gold_left")]
        public int GoldLeft { get; private set; }
        /// <summary>
        /// Gets a round on which this participant was eliminated
        /// </summary>
        [JsonProperty("last_round")]
        public int LastRound { get; private set; }
        /// <summary>
        /// Gets a participant's level upon game end
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; private set; }
        /// <summary>
        /// Gets a participant's placement in game
        /// </summary>
        [JsonProperty("placement")]
        public int Placement { get; private set; }
        /// <summary>
        /// Gets a total amount of players that participant is eliminated
        /// </summary>
        [JsonProperty("players_eliminated")]
        public int PlayersEliminated { get; private set; }
        /// <summary>
        /// Gets total amount of damage dealt to players
        /// </summary>
        [JsonProperty("total_damage_to_players")]
        public int TotalDamageDealtToPlayers { get; private set; }
        /// <summary>
        /// Gets an array of augments IDs for this participant
        /// </summary>
        [JsonProperty("augments")]
        public string[] Augments { get; private set; }
        /// <summary>
        /// Gets a participant's Riot Account PUUID
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> from game start of how long this participant is survived
        /// </summary>
        [JsonProperty("time_eliminated"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan TimeBeforeEliminated { get; private set; }
        /// <summary>
        /// Gets a participant's companion (tactician)
        /// </summary>
        [JsonProperty("companion")]
        public TftCompanion Companion { get; private set; }
        /// <summary>
        /// Gets an array of participant's traits in game
        /// </summary>
        [JsonProperty("traits")]
        public TftTrait[] Traits { get; private set; }
        /// <summary>
        /// Gets an array of participant's units in game
        /// </summary>
        [JsonProperty("units")]
        public TftUnit[] Units { get; private set; }
    }
}
