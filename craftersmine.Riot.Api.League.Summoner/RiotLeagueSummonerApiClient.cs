using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Exceptions;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Summoner
{
    /// <summary>
    /// Represents Riot League of Legends Summoner v4 API
    /// </summary>
    public class RiotLeagueSummonerApiClient : RiotApiClient
    {
        private const string _apiEndpointRoot = "/lol/summoner/v4/summoners/";

        /// <summary>
        /// Creates new instance of <see cref="RiotLeagueSummonerApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings"></param>
        public RiotLeagueSummonerApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a League of legends Summoner account with specified summoner name in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="summonerName">League of Legends summoner name</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RiotApiException"></exception>
        public async Task<LeagueSummoner> GetSummonerByNameAsync(RiotPlatform region, string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(_apiEndpointRoot, "by-name", summonerName));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified Riot Account PUUID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="puuid">Riot Account PUUID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RiotApiException"></exception>
        public async Task<LeagueSummoner> GetSummonerByPuuidAsync(RiotPlatform region, string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(_apiEndpointRoot, "by-puuid", puuid));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified account ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="puuid">Game account ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RiotApiException"></exception>
        public async Task<LeagueSummoner> GetSummonerByAccountIdAsync(RiotPlatform region, string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
                throw new ArgumentNullException(nameof(accountId));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(_apiEndpointRoot, "by-account", accountId));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
        
        /// <summary>
        /// Gets a League of legends Summoner account with specified League of Legends Summoner ID in specified region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="puuid">League of Legends summoner ID</param>
        /// <returns><see cref="LeagueSummoner"/> object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RiotApiException"></exception>
        public async Task<LeagueSummoner> GetSummonerByIdAsync(RiotPlatform region, string summonerId)
        {
            if (string.IsNullOrWhiteSpace(summonerId))
                throw new ArgumentNullException(nameof(summonerId));

            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(_apiEndpointRoot, summonerId));

            LeagueSummoner summoner = await Client.Get<LeagueSummoner>(endpoint, null);
            return summoner;
        }
    }
}
