using System;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.Tournament
{
    public class RiotLeagueTournamentApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/tournament/v4/";
        private const string ApiStubEndpointRoot = "/lol/tournament-stub/v4/";

        public RiotLeagueTournamentApiClient(RiotApiClientSettings settings) : base(settings) { }

        
    }
}
