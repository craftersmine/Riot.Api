using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends player's summoner spell set
    /// </summary>
    public class LeaguePlayerSummonerSpells
    {
        /// <summary>
        /// Gets a first summoner spell information ([D] key)
        /// </summary>
        [JsonProperty("summonerSpellOne")]
        public LeagueSummonerSpell SpellOne { get; private set; }
        /// <summary>
        /// Gets a second summoner spell information ([F] key)
        /// </summary>
        [JsonProperty("summonerSpellTwo")]
        public LeagueSummonerSpell SpellTwo { get; private set; }
    }
}
