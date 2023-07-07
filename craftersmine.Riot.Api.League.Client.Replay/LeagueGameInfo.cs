using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    /// <summary>
    /// Represents information about League of Legends game client
    /// </summary>
    public class LeagueGameInfo
    {
        /// <summary>
        /// Gets current running League of Legends client process ID
        /// </summary>
        [JsonProperty("processID")]
        public int ProcessId { get; private set; }
    }
}
