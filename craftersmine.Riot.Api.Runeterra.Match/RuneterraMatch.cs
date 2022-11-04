using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Runeterra.Matches
{
    /// <summary>
    /// Represents a Legends of Runeterra match
    /// </summary>
    public class RuneterraMatch
    {
        /// <summary>
        /// Gets a match metadata
        /// </summary>
        [JsonProperty("metadata")]
        public RuneterraMatchMetadata Metadata { get; private set; }
        /// <summary>
        /// Gets a match information
        /// </summary>
        [JsonProperty("info")]
        public RuneterraMatchInfo Info { get; private set; }
    }
}
