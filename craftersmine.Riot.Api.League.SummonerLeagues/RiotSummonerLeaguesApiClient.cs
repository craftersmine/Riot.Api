using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    public class RiotSummonerLeaguesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/league/v4/";

        public RiotSummonerLeaguesApiClient(RiotApiClientSettings settings) : base(settings) { }
    }
}