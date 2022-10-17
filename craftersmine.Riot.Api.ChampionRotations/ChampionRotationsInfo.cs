﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.ChampionRotations
{
    public class ChampionRotationsInfo
    {
        /// <summary>
        /// Gets current champions IDs in current free champions rotation
        /// </summary>
        [JsonProperty("freeChampionIds")]
        public int[] FreeChampionIds { get; private set; }
        /// <summary>
        /// Gets current champions IDs in current free champions rotation for new players (whose level is less or equals to <see cref="MaxNewPlayerLevel"/>)
        /// </summary>
        [JsonProperty("freeChampionIdsForNewPlayers")]
        public int[] FreeChampionIdsForNewPlayers { get; private set; }
        /// <summary>
        /// Gets max level for player to be considered player being new
        /// </summary>
        [JsonProperty("maxNewPlayerLevel")]
        public int MaxNewPlayerLevel { get; private set; }
    }
}
