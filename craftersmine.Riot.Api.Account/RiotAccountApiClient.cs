using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Account
{
    /// <summary>
    /// Represents Account v1 Riot API
    /// </summary>
    public class RiotAccountApiClient : RiotApiClient
    {
        private const string _apiEndpointRoot = "/riot/account/v1/accounts/";
        private const string _apiEndpointActiveShardRoot = "/riot/account/v1/active-shards/";

        public RiotAccountApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a Riot Account by specified PUUID
        /// </summary>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="RiotAccount"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<RiotAccount> GetAccountByPuuidAsync(string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion, UriUtils.JoinEndpoints(_apiEndpointRoot, "by-puuid", puuid));

            RiotAccount account =
                await Client.Get<RiotAccount>(endpoint, null);

            return account;
        }

        /// <summary>
        /// Gets a Riot Account by specified RiotID data
        /// </summary>
        /// <param name="riotId">User RiotID</param>
        /// <param name="tag">User RiotID tag (value after # symbol)</param>
        /// <returns><see cref="RiotAccount"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<RiotAccount> GetAccountByRiotIdAsync(string riotId, string tag)
        {
            if (string.IsNullOrWhiteSpace(riotId))
                throw new ArgumentNullException(nameof(riotId));
            if (string.IsNullOrWhiteSpace(tag))
                throw new ArgumentNullException(nameof(tag));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion, UriUtils.JoinEndpoints(_apiEndpointRoot, "by-riot-id", riotId, tag));

            RiotAccount account = await Client.Get<RiotAccount>(endpoint, null);
            return account;
        }

        /// <summary>
        /// Gets active shard of game for specified user
        /// </summary>
        /// <param name="game"><see cref="RiotShardGame"/> for shard</param>
        /// <param name="puuid">User Riot Account PUUID</param>
        /// <returns><see cref="RiotActiveShard"/></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<RiotActiveShard> GetActiveShardForPlayerByPuuidAsync(RiotShardGame game, string puuid)
        {
            if (game == RiotShardGame.Unknown)
                throw new ArgumentException("Invalid game selected!", nameof(game));
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion,
                UriUtils.JoinEndpoints(_apiEndpointActiveShardRoot, "by-game", game.GetShardGameString(), "by-puuid",
                    puuid));

            RiotActiveShard activeShard = await Client.Get<RiotActiveShard>(endpoint, null);
            return activeShard;
        }
    }
}