using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// List of possible Riot API response codes
    /// </summary>
    public enum HttpResponseCode
    {
        /// <summary>
        /// Request successful
        /// </summary>
        Ok = 200,
        /// <summary>
        /// Bad request
        /// </summary>
        BadRequest = 400,
        /// <summary>
        /// Unauthorized
        /// </summary>
        Unauthorized = 401,
        /// <summary>
        /// Forbidden
        /// </summary>
        Forbidden = 403,
        /// <summary>
        /// Data not found
        /// </summary>
        NotFound = 404,
        /// <summary>
        /// Method not allowed
        /// </summary>
        MethodNotAllowed = 405,
        /// <summary>
        /// Unsupported media type
        /// </summary>
        UnsupportedMediaType = 415,
        /// <summary>
        /// API call rate limit exceeded
        /// </summary>
        RateLimitExceeded = 429,
        /// <summary>
        /// Internal Server Error
        /// </summary>
        InternalServerError = 500,
        /// <summary>
        /// Bad gateway
        /// </summary>
        BadGateway = 502,
        /// <summary>
        /// Service unavailable
        /// </summary>
        ServiceUnavailable = 503,
        /// <summary>
        /// Gateway timeout
        /// </summary>
        GatewayTimeout = 504
    }
}
