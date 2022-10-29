using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Spectator
{
    /// <summary>
    /// Represents a League of Legends game observers data
    /// </summary>
    public class LeagueCurrentGameObservers
    {
        /// <summary>
        /// Gets an encryption key that used to decrypt the spectator grid game data for playback
        /// </summary>
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; private set; }
    }
}
