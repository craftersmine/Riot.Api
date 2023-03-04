using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueGameData
    {
        [JsonProperty("activePlayer")]
        public LeagueActivePlayerData ActivePlayer { get; private set; }
        [JsonProperty("players")]
        public LeaguePlayerData[] Players { get; private set; }
        [JsonProperty("events")]
        public LeagueGameEvents Events { get; private set; }
        [JsonProperty("gameData")]
        public LeagueGameMetadata GameData { get; private set; }
    }
}
