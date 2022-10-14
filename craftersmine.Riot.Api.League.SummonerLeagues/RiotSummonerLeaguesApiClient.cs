using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    public class RiotSummonerLeaguesApiClient : RiotApiClient
    {
        private const string _apiEndpointRoot = "/lol/league/v4/";

        public RiotSummonerLeaguesApiClient(RiotApiClientSettings settings) : base(settings) { }
    }
}