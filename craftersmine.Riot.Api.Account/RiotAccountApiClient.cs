using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Account
{
    /// <summary>
    /// Represents Account v1 Riot API
    /// </summary>
    public class RiotAccountApiClient : RiotApiClient
    {
        private const string _apiEndpointRoot = "/riot/account/v1/accounts/";

        public RiotAccountApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<RiotAccount> GetByPuuid(string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.JoinEndpoints(_apiEndpointRoot, "by-puuid", puuid);

            RiotAccount account =
                await Client.Get<RiotAccount>(UriUtils.GetAddress(Settings.DefaultDataRegion, endpoint), null);

            return account;
        }
    }
}