using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    public class LeagueReplayApiClient : RiotApiClient
    {
        protected const string LeagueClientRoot = "https://localhost:2999/replay/";

        /// <summary>
        /// Creates a new instance of <see cref="LeagueReplayApiClient"/>
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueReplayApiClient"/>. IgnoreSSLCertificates is required to be enabled!</param>
        public LeagueReplayApiClient(RiotApiClientSettings settings) : base(settings)
        { }

        public async Task<LeagueGameInfo> GetGameInfoAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "game");

            LeagueGameInfo gameInfo = await Client.GetAsync<LeagueGameInfo>(endpoint, null);
            return gameInfo;
        }
    }
}
