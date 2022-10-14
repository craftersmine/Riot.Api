using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.League.SummonerLeagues.Converters;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents current League of Legends ranked promotion series
    /// </summary>
    public sealed class MiniSeries
    {
        /// <summary>
        /// Gets a count of wins in promotion series
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }
        /// <summary>
        /// Gets a count of losses in promotion series
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }
        /// <summary>
        /// Gets a number of wins to promote in ranked tier
        /// </summary>
        [JsonProperty("target")]
        public int Target { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("progress"), JsonConverter(typeof(MiniSeriesProgressEntriesConverter))]
        public MiniSeriesProgressEntry[]? Progress { get; private set; }
    }

    /// <summary>
    /// Represents state of a promotion series game in progress
    /// </summary>
    public enum MiniSeriesProgressEntry
    {
        /// <summary>
        /// The game was won
        /// </summary>
        Won,
        /// <summary>
        /// The game was lost
        /// </summary>
        Lost,
        /// <summary>
        /// The game has not been played yet
        /// </summary>
        NotPlayed
    }
}
