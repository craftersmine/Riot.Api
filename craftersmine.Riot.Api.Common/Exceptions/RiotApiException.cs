using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace craftersmine.Riot.Api.Common.Exceptions
{
    [Serializable]
    public class RiotApiException : Exception
    {
        public ErrorResponse RiotApiResponse { get; private set; }
        public HttpResponseCode ResponseCode { get; private set; }

        public RiotApiException(HttpResponseCode responseCode)
        {
            ResponseCode = responseCode;
            RiotApiResponse = null;
        }

        public RiotApiException(ErrorResponse response) : base(response.Status.Message)
        {
            RiotApiResponse = response;
        }

        public RiotApiException(ErrorResponse response, Exception inner) : base(response.Status.Message, inner)
        {
            RiotApiResponse = response;
        }

        protected RiotApiException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
