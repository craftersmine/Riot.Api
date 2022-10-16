using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Summoner
{
    /// <summary>
    /// Represents a League of Legends summoner account
    /// </summary>
    public class LeagueSummoner
    {
        /// <summary>
        /// Gets an encrypted account ID. Max length is 56 characters
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; private set; }
        /// <summary>
        /// Gets a League of Legends summoner account name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// Gets an encrypted summoner ID. Max length is 63 characters
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
        /// <summary>
        /// Gets a Riot Account PUUID
        /// </summary>
        [JsonProperty("puuid")]
        public string RiotPuuid { get; private set; }
        /// <summary>
        /// Gets an ID of League of Legends summoner profile icon
        /// </summary>
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; private set; }
        /// <summary>
        /// Gets a League of Legends summoner level
        /// </summary>
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> in GMT timezone when League of Legends summoner account was modified (summoner name change, level change or profile icon change)
        /// </summary>
        [JsonProperty("revisionDate"), JsonConverter(typeof(craftersmine.Riot.Api.Common.Converters.UnixDateTimeConverter))]
        public DateTime RevisionDate { get; private set; }
    }
}