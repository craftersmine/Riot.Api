using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    public class LeagueActivePlayerData
    {
        public int ChampiontLevel { get; private set; }
        public bool HasRelativeTeamColors { get; private set; }
        public double CurrentGold { get; private set; }
        public string SummonerName { get; private set; }
        public LeagueChampionAbilities Abilities { get; private set; }
        public LeagueChampionStats ChampionStats { get; private set; }
        public LeaguePlayerRunes Runes { get; private set; }
    }
}
