﻿using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueGameClientApiClient : RiotApiClient
    {
        private const string LeagueClientRoot = "https://localhost:2999/liveclientdata/";

        public LeagueGameClientApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<LeagueGameData> GetAllGameDataAsync()
        {
            string endpoint = UriUtils.JoinEndpoints(LeagueClientRoot, "allgamedata");

            LeagueGameData gameData = await Client.GetAsync<LeagueGameData>(endpoint, null);
            return gameData;
        }
    }
}