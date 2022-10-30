using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Summoner
{
    /// <summary>
    /// Represents Riot League of Legends Summoner v4 API
    /// </summary>
    public class LeagueSummonerApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/summoner/v4/summoners/";

        /// <summary>
        /// Creates new instance of <see cref="LeagueSummonerApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings"></param>
        public LeagueSummonerApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a League of legends Summoner account with specified summoner name in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerName">League of Legends summoner name</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByNameAsync(RiotPlatform region, string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-name", summonerName));

            LeagueSummoner summoner = await Client.GetAsync<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified Riot Account PUUID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When PUUID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByPuuidAsync(RiotPlatform region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-puuid", puuid));

            LeagueSummoner summoner = await Client.GetAsync<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified account ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="accountId">Game account ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When Riot Account ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByAccountIdAsync(RiotPlatform region, string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "by-account", accountId));

            LeagueSummoner summoner = await Client.GetAsync<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified League of Legends Summoner ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerId">League of Legends summoner ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException">When League of Legends summoner ID is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueSummoner> GetSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, summonerId));

            LeagueSummoner summoner = await Client.GetAsync<LeagueSummoner>(endpoint, null);
            return summoner;
        }
    }
}
