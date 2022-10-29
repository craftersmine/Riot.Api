using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace craftersmine.Riot.Api.Common.Exceptions
{
    /// <summary>
    /// Represents a failed request information from Riot Games API
    /// </summary>
    [Serializable]
    public class RiotApiException : Exception
    {
        /// <summary>
        /// Gets a Riot Games API error response information
        /// </summary>
        public ErrorResponse RiotApiResponse { get; private set; }
        /// <summary>
        /// Gets a HTTP response status code
        /// </summary>
        public HttpResponseCode ResponseCode { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="RiotApiException"/>
        /// </summary>
        /// <param name="responseCode">HTTP response status code</param>
        public RiotApiException(HttpResponseCode responseCode)
        {
            ResponseCode = responseCode;
            RiotApiResponse = null;
        }
        
        /// <summary>
        /// Creates a new instance of <see cref="RiotApiException"/>
        /// </summary>
        /// <param name="response">Riot Games API error response</param>
        public RiotApiException(ErrorResponse response) : base(response.Status.Message)
        {
            RiotApiResponse = response;
            ResponseCode = (HttpResponseCode)response.Status.StatusCode;
        }
        
        /// <summary>
        /// Creates a new instance of <see cref="RiotApiException"/>
        /// </summary>
        /// <param name="response">Riot Games API error response</param>
        /// <param name="inner">Inner exception</param>
        public RiotApiException(ErrorResponse response, Exception inner) : base(response.Status.Message, inner)
        {
            RiotApiResponse = response;
            ResponseCode = (HttpResponseCode)response.Status.StatusCode;
        }
        
        /// <summary>
        /// Creates a new instance of <see cref="RiotApiException"/>
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected RiotApiException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
