using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;
using craftersmine.Riot.Api.League.Summoner;

namespace craftesmine.Riot.Api.Tft.Summoner
{
    /// <summary>
    /// Represents Riot Teamfight Tactics Summoner v1 API
    /// </summary>
    public class RiotTftSummonerApiClient : RiotApiClient
    {
        private const string ApiEndpointsRoot = "/tft/summoner/v1/summoners";
        /// <summary>
        /// Creates new instance of <see cref="RiotTftSummonerApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="RiotTftSummonerApiClient"/></param>
        public RiotTftSummonerApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a Teamfight Tactics Summoner account with specified Teamfight Tactics Summoner ID in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="summonerId">Teamfight Tactics summoner ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When Teamfight Tactics summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointsRoot, summonerId));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }

        /// <summary>
        /// Gets a Teamfight Tactics Summoner account with specified Riot Account PUUID in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When PUUID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByPuuidAsync(RiotPlatform region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointsRoot, "by-puuid", puuid));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }

        /// <summary>
        /// Gets a Teamfight Tactics Summoner account with specified summoner name in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="summonerName">Teamfight Tactics summoner name</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByNameAsync(RiotPlatform region, string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointsRoot, "by-name", summonerName));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }

        /// <summary>
        /// Gets a Teamfight Tactics Summoner account with specified account ID in specified region
        /// </summary>
        /// <param name="region">Teamfight Tactics server region</param>
        /// <param name="accountId">Game account ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When Riot Account ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByAccountIdAsync(RiotPlatform region, string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointsRoot, "by-account", accountId));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
    }
}
