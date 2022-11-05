using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueLocalApiClient : RiotApiClient
    {
        public LeagueLocalApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<LeagueGameData> GetAllGameDataAsync()
        {

        }
    }
}
