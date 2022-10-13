using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Account
{
    /// <summary>
    /// Represents a Riot Account
    /// </summary>
    public class RiotAccount
    {
        /// <summary>
        /// Gets Riot Account PUUID
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets Riot Account name (value before # symbol)
        /// </summary>
        [JsonProperty("gameName")]
        public string GameName { get; private set; }
        /// <summary>
        /// Gets Riot Account tag (value after # symbol)
        /// </summary>
        [JsonProperty("tagLine")]
        public string TagLine { get; private set; }
    }
}
