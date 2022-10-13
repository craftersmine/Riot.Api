using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents an error response from Riot API servers
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Gets a Riot API error information
        /// </summary>
        [JsonProperty("status")]
        public RiotApiErrorInfo Status { get; private set; }
    }

    /// <summary>
    /// Represents an error response information from Riot API servers
    /// </summary>
    public class RiotApiErrorInfo
    {
        /// <summary>
        /// Get a human-readable error message describing what went wrong with request
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }
        /// <summary>
        /// Gets a HTTP response code of error
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; private set; }
    }
}
