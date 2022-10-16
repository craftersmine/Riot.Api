using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Clash.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash
{
    /// <summary>
    /// Represents a League of Legends Clash team
    /// </summary>
    public class LeagueClashTeam
    {
        /// <summary>
        /// Gets a tournament ID in which this team participates
        /// </summary>
        [JsonProperty("tournamentId")]
        public int TournamentId { get; private set; }
        /// <summary>
        /// Gets an icon ID of icon this team is using
        /// </summary>
        [JsonProperty("iconId")]
        public int IconId { get; private set; }
        /// <summary>
        /// Gets a Clash team ID of this team
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
        /// <summary>
        /// Gets a team name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets an abbreviation this team is using for short team name
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; private set; }
        /// <summary>
        /// Gets a League of Legends team captain summoner ID
        /// </summary>
        [JsonProperty("captain")]
        public string CaptainSummonerId { get; private set; }
        /// <summary>
        /// Gets a team tier
        /// </summary>
        [JsonProperty("tier"), JsonConverter(typeof(LeagueClashTeamTierConverter))]
        public LeagueClashTeamTier Tier { get; private set; }
        /// <summary>
        /// Gets an array of players which are a part of this team
        /// </summary>
        [JsonProperty("players")]
        public LeagueClashPlayer[] Players { get; private set; }
    }
}
