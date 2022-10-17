using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Matches
{
    public class LeagueMatchParticipant
    {
        public int Assists { get; private set; }
        public int BaronKills { get; private set; }
        public int ChampionExperience { get; private set; }
        public int ChampionLevel { get; private set; }
        public int ConsumablesPurchased { get; private set; }
        public int CrowdControlScore{ get; private set; } // times ccd others
        public int DamageDealtToBuildings { get; private set; }
        public int DamageDealtToObjectives { get; private set; }
        public int DamageDealtToTurrets { get; private set; }
        public int DamageSelfMitigated { get; private set; }
        public int Deaths { get; private set; }
        public int ControlWardsPlaced { get; private set; }
        public int Doublekills { get; private set; }
        public int DragonKills { get; private set; }
        public int GoldEarned { get; private set; }
        public int GoldSpent { get; private set; }
        public int InhibitorsKills { get; private set; } 
        public int InhibitorsDestroyed { get; private set; }
        public int InhibitorsLost { get; private set; }
        public int Slot0ItemId { get; private set; }
        public int Slot1ItemId { get; private set; }
        public int Slot2ItemId { get; private set; }
        public int Slot3ItemId { get; private set; }
        public int Slot4ItemId { get; private set; }
        public int Slot5ItemId { get; private set; }
        public int Slot6ItemId { get; private set; }
        public int ItemsTotalPurchased { get; private set; }
        public int KillingSprees { get; private set; }
        public int Kills { get; private set; }
        public int LargestCriticalStrike { get; private set; }
        public int LargestKillingSpree { get; private set; }
        public int MagicDamageDealt { get; private set; }
        public int MagicDamageDealtToChampions { get; private set; }
        public int MagicDamageTaken { get; private set; }
        public int NeutralMinionsKilled { get; private set; }
        public int NexusKills { get; private set; }
        public int NexusTakedowns { get; private set; }
        public int NexusLost { get; private set; }
        public int ObjectivesStolen { get; private set; }
        public int ObjectivesStolenAssists { get; private set; }
        public int Id { get; private set; }
        public int Pentakills { get; private set; }
        public int PhysicalDamageDealt { get; private set; }
        public int PhysicalDamageDealtToChampions { get; private set; }
        public int PhysicalDamageTaken { get; private set; }
        public int ProfileIconId { get; private set; }
        public int Quadrakills { get; private set; }
        public int SightWardsBought { get; private set; }
        public int Spell1Casts { get; private set; }
        public int Spell2Casts { get; private set; }
        public int Spell3Casts { get; private set; }
        public int Spell4Casts { get; private set; }
        public int SummonerSpell1Casts { get; private set; }
        public int SummonerSpell2Casts { get; private set; }
        public int SummonerSpell1Id { get; private set; }
        public int SummonerSpell2Id { get; private set; }
        public int SummonerLevel { get; private set; }
        public int TeamId { get; private set; }
        public int TotalDamageDealt { get; private set; }
        public int TotalDamageDealtToChampions { get; private set; }
        public int TotalDamageShieldedOnTeammates { get; private set; }
        public int TotalDamageTaken { get; private set; }
        public int TotalHeal { get; private set; }
        public int TotalHealOnTeammates { get; private set; }
        public int TotalMinionsKilled { get; private set; }
        public int TotalUnitsHealed { get; private set; }
        public int Triplekills { get; private set; }
        public int TrueDamageDealt { get; private set; }
        public int TrueDamageDealtToChampions { get; private set; }
        public int TrueDamageTaken { get; private set; }
        public int TurretKills { get; private set; }
        public int TurretTakedowns { get; private set; }
        public int TurretsLost { get; private set; }
        public int Unrealkills { get; private set; }
        public int VisionScore { get; private set; }
        public int VisionWardsBought { get; private set; } // control wards
        public int WardsKilled { get; private set; }
        public int WardsPlaced { get; private set; }

        public bool FirstBloodAssist { get; private set; }
        public bool FirstBlood { get; private set; }
        public bool FirstTowerAssist { get; private set; }
        public bool FirstTower { get; private set; }
        public bool GameEndedInEarlySurrender { get; private set; }
        public bool GameEndedInSurrender { get; private set; }
        public bool TeamEarlySurrendered { get; private set; }
        public bool Win { get; private set; }

        public string ChampionName { get; private set; }
        public string Puuid { get; private set; }
        public string RiotIdName { get; private set; }
        public string RiotIdTagline { get; private set; }
        public string SummonerId { get; private set; }
        public string SummonerName { get; private set; }

        // enums
        [JsonConverter(typeof(LeagueBountyLevelConverter))]
        public LeagueBountyLevel BountyLevel { get; private set; }
        public LeagueChampionTransform ChampionTransform { get; private set; } // currently only for Kayn transforms
        public LeagueMultikill LargestMultikill { get; private set; }
        public LeagueMatchPosition IndividualPosition { get; private set; }
        public LeagueMatchPosition Lane { get; private set; }
        public LeagueMatchPosition TeamPosition { get; private set; }
        public LeagueMatchRole Role { get; private set; }

        // structs
        public TimeSpan LongestTimeSpentLiving { get; private set; } // timespan seconds
        public TimeSpan TimePlayed { get; private set; } // timespan seconds
        public TimeSpan TotalCrowdControlTimeDealt { get; private set; } // timespan seconds
        public TimeSpan TotalTimeSpentDead { get; private set; } // timespan seconds

        // classes
        public LeagueChampionRunes Runes { get; private set; } // perks
        [JsonConverter(typeof(KeyValuePairConverter))]
        public LeagueChallengesCollection Challenges { get; private set; } // challenges
    }
}
