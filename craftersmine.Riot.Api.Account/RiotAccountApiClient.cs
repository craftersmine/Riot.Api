using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Account
{
    /// <summary>
    /// Represents Account v1 Riot API
    /// </summary>
    public class RiotAccountApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/riot/account/v1/accounts/";
        private const string ApiEndpointActiveShardRoot = "/riot/account/v1/active-shards/";

        /// <summary>
        /// Creates a new instance of <see cref="RiotAccountApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotAccountApiClient"/></param>
        public RiotAccountApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a Riot Account by specified PUUID
        /// </summary>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="RiotAccount"/></returns>
        /// <exception cref="ArgumentNullException">When PUUID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<RiotAccount> GetAccountByPuuidAsync(string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid));

            RiotAccount account =
                await Client.GetAsync<RiotAccount>(endpoint, null);

            return account;
        }

        /// <summary>
        /// Gets a Riot Account by specified RiotID data
        /// </summary>
        /// <param name="riotId">User RiotID</param>
        /// <param name="tag">User RiotID tag (value after # symbol)</param>
        /// <returns><see cref="RiotAccount"/></returns>
        /// <exception cref="ArgumentNullException">When RiotID or Tag is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<RiotAccount> GetAccountByRiotIdAsync(string riotId, string tag)
        {
            if (string.IsNullOrWhiteSpace(riotId))
                throw new ArgumentNullException(nameof(riotId));
            if (string.IsNullOrWhiteSpace(tag))
                throw new ArgumentNullException(nameof(tag));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-riot-id", riotId, tag));

            RiotAccount account = await Client.GetAsync<RiotAccount>(endpoint, null);
            return account;
        }

        /// <summary>
        /// Gets active shard of game for specified user
        /// </summary>
        /// <param name="game"><see cref="RiotShardGame"/> for shard</param>
        /// <param name="puuid">User Riot Account PUUID</param>
        /// <returns><see cref="RiotActiveShard"/></returns>
        /// <exception cref="ArgumentException">When selected game is Unknown</exception>
        /// <exception cref="ArgumentNullException">When PUUID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<RiotActiveShard> GetActiveShardForPlayerByPuuidAsync(RiotShardGame game, string puuid)
        {
            if (game == RiotShardGame.Unknown)
                throw new ArgumentException("Invalid game selected!", nameof(game));
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(Settings.DefaultDataRegion,
                UriUtils.JoinEndpoints(ApiEndpointActiveShardRoot, "by-game", game.GetShardGameString(), "by-puuid",
                    puuid));

            RiotActiveShard activeShard = await Client.GetAsync<RiotActiveShard>(endpoint, null);
            return activeShard;
        }
    }
}