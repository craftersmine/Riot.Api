using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a League of Legends Challenges v1 API client
    /// </summary>
    public class LeagueChallengesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/challenges/v1/";
        
        /// <summary>
        /// Creates a new instance of <see cref="LeagueChallengesApiClient"/> instance
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueChallengesApiClient"/></param>
        public LeagueChallengesApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets a collection of available challenges and their data in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <returns>A collection of current available challenges and their configured values</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallengeCollection> GetLeagueChallenges(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges/config"));

            LeagueChallengeCollection leagueChallenges = await Client.GetAsync<LeagueChallengeCollection>(endpoint, null);
            return leagueChallenges;
        }
        
        /// <summary>
        /// Gets a collection of current challenges player level percentiles in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <returns>A collection of current challenges level percentiles in specified League of Legends server</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallengePercentilesCollection> GetLeagueChallengePercentilesAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges/percentiles"));

            LeagueChallengePercentilesCollection leagueChallengePercentiles = await Client.GetAsync<LeagueChallengePercentilesCollection>(endpoint, null);
            return leagueChallengePercentiles;
        }

        /// <summary>
        /// Gets a challenge data by specified challenge ID in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns>Challenge data of challenge with specified ID</returns>
        /// <exception cref="ArgumentOutOfRangeException">When challenge ID is less than 0</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallenge> GetLeagueChallengeByIdAsync(RiotPlatform region, int challengeId)
        {
            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "config"));

            LeagueChallenge challenge = await Client.GetAsync<LeagueChallenge>(endpoint, null);
            return challenge;
        }

        /// <summary>
        /// Gets a challenge leaderboard collection for challenge with specified ID in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="challengeLevel">Challenge level to fetch a leaderboard for (avaliable values are: Master, Grandmaster, Challenger</param>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <param name="amount">An amount of entries to fetch</param>
        /// <returns>A collection of challenge leaderboard for specified challenge ID and level</returns>
        /// <exception cref="ArgumentException">When <see cref="challengeLevel"/> is not <see cref="LeagueChallengeLevel.Master"/>, <see cref="LeagueChallengeLevel.Grandmaster"/> or <see cref="LeagueChallengeLevel.Challenger"/></exception>
        /// <exception cref="ArgumentOutOfRangeException">When <see cref="challengeId"/> is less than 0 or <see cref="amount"/> is less than 1</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallengeLeaderboardEntryCollection> GetLeagueChallengeLeaderboardByChallengeIdAsync(
            RiotPlatform region, LeagueChallengeLevel challengeLevel, int challengeId, int amount)
        {
            if (challengeLevel != LeagueChallengeLevel.Master && challengeLevel != LeagueChallengeLevel.Grandmaster &&
                challengeLevel != LeagueChallengeLevel.Challenger)
                throw new ArgumentException(
                    "Only Master, Grandmaster and Challenger level are available for fetching leaderboards",
                    nameof(challengeLevel));

            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            if (amount < 1)
                throw new ArgumentOutOfRangeException(nameof(amount), "Can't fetch less than 1 leaderboard entry");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "leaderboards/by-level/",
                    challengeLevel.GetStringFor()));

            LeagueChallengeLeaderboardEntryCollection leaderboardEntryCollection =
                await Client.GetAsync<LeagueChallengeLeaderboardEntryCollection>(endpoint,
                    new Dictionary<string, object>() {{"limit", amount}});

            return leaderboardEntryCollection;
        }

        /// <inheritdoc cref="GetLeagueChallengeLeaderboardByChallengeIdAsync(RiotRegion, LeagueChallengeLevel, int, int)"/>
        public async Task<LeagueChallengeLeaderboardEntryCollection> GetLeagueChallengeLeaderboardByChallengeIdAsync(
            RiotPlatform region, LeagueChallengeLevel challengeLevel, int challengeId)
        {
            if (challengeLevel != LeagueChallengeLevel.Master && challengeLevel != LeagueChallengeLevel.Grandmaster &&
                challengeLevel != LeagueChallengeLevel.Challenger)
                throw new ArgumentException(
                    "Only Master, Grandmaster and Challenger level are available for fetching leaderboards",
                    nameof(challengeLevel));

            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "leaderboards/by-level/",
                    challengeLevel.GetStringFor()));

            LeagueChallengeLeaderboardEntryCollection leaderboardEntryCollection =
                await Client.GetAsync<LeagueChallengeLeaderboardEntryCollection>(endpoint, null);

            return leaderboardEntryCollection;
        }

        /// <summary>
        /// Gets a percentiles in levels for challenge by challenge ID in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="challengeId">League of Legends challenge ID</param>
        /// <returns><see cref="LeagueChallengePercentiles"/> for specified challenge by challenge ID</returns>
        /// <exception cref="ArgumentOutOfRangeException">When challenge ID is less than 0</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallengePercentiles> GetLeagueChallengePercentilesByChallengeIdAsync(
            RiotPlatform region, int challengeId)
        {
            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "percentiles"));

            LeagueChallengePercentiles challengePercentiles =
                await Client.GetAsync<LeagueChallengePercentiles>(endpoint, null);
            return challengePercentiles;
        }

        /// <summary>
        /// Gets a challenges related information of player by specified Riot Account PUUID in specified League of Legends server region
        /// </summary>
        /// <param name="region">League of Legends server region</param>
        /// <param name="puuid">Riot Account player PUUID</param>
        /// <returns><see cref="LeagueChallenegsPlayerData"/> for specified player by Riot PUUID</returns>
        /// <exception cref="ArgumentNullException">When <see cref="puuid"/> is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChallengesPlayerData> GetLeagueChallengesForPlayerByPuuid(RiotPlatform region,
            string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "player-data", puuid));

            LeagueChallengesPlayerData challengesPlayerData =
                await Client.GetAsync<LeagueChallengesPlayerData>(endpoint, null);

            return challengesPlayerData;
        }
    }
}
