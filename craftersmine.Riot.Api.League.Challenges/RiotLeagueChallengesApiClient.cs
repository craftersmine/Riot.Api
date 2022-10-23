using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Challenges
{
    public class RiotLeagueChallengesApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/lol/challenges/v1/";

        public RiotLeagueChallengesApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<LeagueChallengeCollection> GetLeagueChallenges(RiotPlatform region)
        {
            string endpoint = UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges/config"));

            LeagueChallengeCollection leagueChallenges = await Client.Get<LeagueChallengeCollection>(endpoint, null);
            return leagueChallenges;
        }

        public async Task<LeagueChallengePercentilesCollection> GetLeagueChallengePercentilesAsync(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges/percentiles"));

            LeagueChallengePercentilesCollection leagueChallengePercentiles = await Client.Get<LeagueChallengePercentilesCollection>(endpoint, null);
            return leagueChallengePercentiles;
        }

        public async Task<LeagueChallenge> GetLeagueChallengeByIdAsync(RiotPlatform region, int challengeId)
        {
            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "config"));

            LeagueChallenge challenge = await Client.Get<LeagueChallenge>(endpoint, null);
            return challenge;
        }

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
                await Client.Get<LeagueChallengeLeaderboardEntryCollection>(endpoint,
                    new Dictionary<string, object>() {{"limit", amount}});

            return leaderboardEntryCollection;
        }

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
                await Client.Get<LeagueChallengeLeaderboardEntryCollection>(endpoint, null);

            return leaderboardEntryCollection;
        }

        public async Task<LeagueChallengePercentiles> GetLeagueChallengePercentilesByChallengeIdAsync(
            RiotPlatform region, int challengeId)
        {
            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "percentiles"));

            LeagueChallengePercentiles challengePercentiles =
                await Client.Get<LeagueChallengePercentiles>(endpoint, null);
            return challengePercentiles;
        }

        public async Task<LeagueChallengesPlayerData> GetLeagueChallengesForPlayerByPuuid(RiotPlatform region,
            string puuid)
        {
            if (string.IsNullOrWhiteSpace(puuid))
                throw new ArgumentNullException(nameof(puuid));

            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "player-data", puuid));

            LeagueChallengesPlayerData challengesPlayerData =
                await Client.Get<LeagueChallengesPlayerData>(endpoint, null);

            return challengesPlayerData;
        }
    }
}
