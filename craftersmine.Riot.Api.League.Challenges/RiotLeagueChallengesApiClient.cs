using System;
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

        public async Task<LeagueChallengePercentilesCollection> GetLeagueChallengePercentiles(RiotPlatform region)
        {
            string endpoint =
                UriUtils.GetAddress(region, UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges/percentiles"));

            LeagueChallengePercentilesCollection leagueChallengePercentiles = await Client.Get<LeagueChallengePercentilesCollection>(endpoint, null);
            return leagueChallengePercentiles;
        }

        public async Task<LeagueChallenge> GetLeagueChallengeById(RiotPlatform region, int challengeId)
        {
            if (challengeId < 0)
                throw new ArgumentOutOfRangeException(nameof(challengeId), "League of Legends Challenge ID cannot be less than 0");

            string endpoint = UriUtils.GetAddress(region,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "challenges", challengeId.ToString(), "config"));

            LeagueChallenge challenge = await Client.Get<LeagueChallenge>(endpoint, null);
            return challenge;
        }
    }
}
