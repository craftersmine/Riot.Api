using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;
using craftersmine.Riot.Api.League.Summoner;

namespace craftesmine.Riot.Api.Tft.Summoner
{
    public class RiotTftSummonerApiClient : RiotApiClient
    {
        private const string ApiEndpointsRoot = "/tft/summoner/v1/summoners";

        public RiotTftSummonerApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<LeagueSummoner> GetSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointsRoot, summonerId));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
    }
}
