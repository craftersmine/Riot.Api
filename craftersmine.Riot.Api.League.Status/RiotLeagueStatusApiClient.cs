using System;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.Status
{
    public class RiotLeagueStatusApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/status/v4";

        public RiotLeagueStatusApiClient(RiotApiClientSettings settings) : base(settings)
        { }
    }
}
