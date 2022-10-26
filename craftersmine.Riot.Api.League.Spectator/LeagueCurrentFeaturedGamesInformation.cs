using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a League of Legends featured games information
    /// </summary>
    public class LeagueCurrentFeaturedGamesInformation
    {
        /// <summary>
        /// Gets an array of featured games list
        /// </summary>
        [JsonProperty("gameList")]
        public LeagueCurrentGameInfo[] GameList { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> interval to wait before next featured games list update
        /// </summary>
        [JsonProperty("clientRefreshInterval"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan ClientRefreshInterval { get; private set; }
    }
}
