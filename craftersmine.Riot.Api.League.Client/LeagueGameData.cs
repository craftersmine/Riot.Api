using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueGameData
    {
        public LeagueActivePlayerData ActivePlayer { get; private set; }
        public LeaguePlayerData[] Players { get; private set; }
        public LeagueEvent[] Events { get; private set; }
        public LeagueGameMetadata GameData { get; private set; }
    }
}
