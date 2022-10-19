using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Matches.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends match participant
    /// </summary>
    public class LeagueMatchParticipant
    {
        /// <summary>
        /// Gets a total amount of assists in game for this participant
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; private set; }
        /// <summary>
        /// Gets a total amount of Baron Nashor kills made by this participant
        /// </summary>
        [JsonProperty("baronKills")]
        public int BaronKills { get; private set; }
        /// <summary>
        /// Gets a total amount of pings used in game
        /// </summary>
        [JsonProperty("basicPings")]
        public int BasicPings { get; private set; }
        /// <summary>
        /// Gets a total amount of experience earned on participant champion
        /// </summary>
        [JsonProperty("champExperience")]
        public int ChampionExperience { get; private set; }
        /// <summary>
        /// Gets a maximum level reached on participant champion
        /// </summary>
        [JsonProperty("champLevel")]
        public int ChampionLevel { get; private set; }
        /// <summary>
        /// Gets an internal League of Legends champion ID of this participant
        /// </summary>
        /// <remarks>
        /// Prior to patch 11.4, on Feb 18th, 2021, this field returned invalid champion IDs. <br/>
        /// It is recommended to determine champion based on <see cref="ChampionName"/> property value <br/>
        /// for games prior to patch 11.4
        /// </remarks>
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
        /// <summary>
        /// Gets a total amount of consumables purchased in game by this participant
        /// </summary>
        [JsonProperty("consumablesPurchased")]
        public int ConsumablesPurchased { get; private set; }
        /// <summary>
        /// Gets a total amount of crowd control applied to others (also known as crowd control score) by this participant
        /// </summary>
        [JsonProperty("timeCCingOthers")]
        public int CrowdControlScore{ get; private set; }
        /// <summary>
        /// Gets a total amount of control wards placed in game by this participant
        /// </summary>
        [JsonProperty("detectorWardsPlaced")]
        public int ControlWardsPlaced { get; private set; }
        /// <summary>
        /// Gets a total amount of damage dealt to buildings (inhibitors and nexus) by champion of this participant
        /// </summary>
        [JsonProperty("damageDealtToBuildings")]
        public int DamageDealtToBuildings { get; private set; }
        /// <summary>
        /// Gets a total amount of damage dealt to objectives (dragons, Baron's, Heralds, etc.) by champion of this participant
        /// </summary>
        [JsonProperty("damageDealtToObjectives")]
        public int DamageDealtToObjectives { get; private set; }
        /// <summary>
        /// Gets a total amount of damage dealt to turrets by champion of this participant
        /// </summary>
        [JsonProperty("damageDealtToTurrets")]
        public int DamageDealtToTurrets { get; private set; }
        /// <summary>
        /// Gets a total amount of self-mitigated damage dealt to champion of this participant
        /// </summary>
        [JsonProperty("damageSelfMitigated")]
        public int DamageSelfMitigated { get; private set; }
        /// <summary>
        /// Gets an amount of total deaths in game for this participant
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }
        /// <summary>
        /// Gets a total amount of double kills made in game by this participant
        /// </summary>
        [JsonProperty("doubleKills")]
        public int DoubleKills { get; private set; }
        /// <summary>
        /// Gets a total amount of dragons killed by this participant
        /// </summary>
        [JsonProperty("dragonKills")]
        public int DragonKills { get; private set; }
        /// <summary>
        /// Gets a total amount of gold earned by this participant
        /// </summary>
        [JsonProperty("goldEarned")]
        public int GoldEarned { get; private set; }
        /// <summary>
        /// Gets a total amount of gold spent by this participant
        /// </summary>
        [JsonProperty("goldSpent")]
        public int GoldSpent { get; private set; }
        /// <summary>
        /// Gets a total amount of inhibitors kills assists for this participant
        /// </summary>
        [JsonProperty("inhibitorKills")]
        public int InhibitorsKillsAssists { get; private set; }
        /// <summary>
        /// Gets a total amount of inhibitors destroyed by this participant
        /// </summary>
        [JsonProperty("inhibitorsTakedowns")]
        public int InhibitorsDestroyed { get; private set; }
        /// <summary>
        /// Gets a total amount of team inhibitors lost by this participant
        /// </summary>
        [JsonProperty("inhibitorsLost")]
        public int InhibitorsLost { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 0 (slot under key 1 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item0")]
        public int Slot0ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 1 (slot under key 2 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item1")]
        public int Slot1ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 2 (slot under key 3 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item2")]
        public int Slot2ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 3 (slot under key 4 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item3")]
        public int Slot3ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 4 (slot under key 5 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item4")]
        public int Slot4ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 5 (slot under key 6 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item5")]
        public int Slot5ItemId { get; private set; }
        /// <summary>
        /// Gets an ID of item in slot 6 (slot under key 7 in game) for this participant's champion
        /// </summary>
        [JsonProperty("item6")]
        public int Slot6ItemId { get; private set; }
        /// <summary>
        /// Gets a total amount of items purchased by this participant
        /// </summary>
        [JsonProperty("itemsPurchased")]
        public int ItemsTotalPurchased { get; private set; }
        /// <summary>
        /// Gets a total amount of killing sprees this participant had in game (2 and more consecutive kills for multiple periods of time)
        /// </summary>
        [JsonProperty("killingSprees")]
        public int KillingSprees { get; private set; }
        /// <summary>
        /// Gets a total amount of kills this participant made in game
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }
        /// <summary>
        /// Gets a largest critical strike value dealt by the champion of this participant
        /// </summary>
        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; private set; }
        /// <summary>
        /// Gets a maximum amount of kills made in all killing sprees this participant had in game
        /// </summary>
        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; private set; }
        /// <summary>
        /// Gets a total amount of magic damage dealt by champion of this participant
        /// </summary>
        [JsonProperty("magicDamageDealt")]
        public int MagicDamageDealt { get; private set; }
        /// <summary>
        /// Gets a total amount of magic damage dealt to only other champions by champion of this participant
        /// </summary>
        [JsonProperty("magicDamageDealtToChampions")]
        public int MagicDamageDealtToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of magic damage taken from any source by champion of this participant (premitigated?)
        /// </summary>
        [JsonProperty("magicDamageTaken")]
        public int MagicDamageTaken { get; private set; }
        /// <summary>
        /// Gets a total amount of jungle minions killed by champion of this participant
        /// </summary>
        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; private set; }
        /// <summary>
        /// Gets a total amount of Nexus kills by this participant
        /// </summary>
        [JsonProperty("nexusKills")]
        public int NexusKills { get; private set; }
        /// <summary>
        /// Gets a total amount of Nexus takedowns by this participant
        /// </summary>
        [JsonProperty("nexusTakedowns")]
        public int NexusTakedowns { get; private set; }
        /// <summary>
        /// Gets a total amount of Nexuses lost by this participant
        /// </summary>
        [JsonProperty("nexusLost")]
        public int NexusLost { get; private set; }
        /// <summary>
        /// Gets a total amount of objectives stolen by this participant
        /// </summary>
        [JsonProperty("objectivesStolen")]
        public int ObjectivesStolen { get; private set; }
        /// <summary>
        /// Gets a total amount of objectives stealing assists made by this participant
        /// </summary>
        [JsonProperty("objectivesStolenAssists")]
        public int ObjectivesStolenAssists { get; private set; }
        /// <summary>
        /// Gets a participant ID in this game (index that starts from 1 that corresponds to participant in <see cref="LeagueMatchInfo.Participants"/> array)
        /// </summary>
        [JsonProperty("participantId")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets a total amount of penta kills made by this participant in this game
        /// </summary>
        [JsonProperty("pentaKills")]
        public int PentaKills { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage dealt by champion of this participant
        /// </summary>
        [JsonProperty("physicalDamageDealt")]
        public int PhysicalDamageDealt { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage dealt to only other champions by champion of this participant
        /// </summary>
        [JsonProperty("physicalDamageDealtToChampions")]
        public int PhysicalDamageDealtToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of physical damage taken from any source by champion of this participant (premitigated?)
        /// </summary>
        [JsonProperty("physicalDamageTaken")]
        public int PhysicalDamageTaken { get; private set; }
        /// <summary>
        /// Gets a participants Profile Icon ID
        /// </summary>
        [JsonProperty("profileIcon")]
        public int ProfileIconId { get; private set; }
        /// <summary>
        /// Gets a total amount of quadra kills made by this participant in this game
        /// </summary>
        [JsonProperty("quadraKills")]
        public int QuadraKills { get; private set; }
        /// <summary>
        /// Gets a total amount of Sight wards bought in game by this participant
        /// </summary>
        [JsonProperty("sightwardsBoughtInGame")]
        public int SightWardsBought { get; private set; }
        /// <summary>
        /// Gets a total amount of first spell [Q] casts in game by this participant
        /// </summary>
        [JsonProperty("spell1Casts")]
        public int Spell1CastsCount { get; private set; }
        /// <summary>
        /// Gets a total amount of second spell [W] casts in game by this participant 
        /// </summary>
        [JsonProperty("spell2Casts")]
        public int Spell2CastsCount { get; private set; }
        /// <summary>
        /// Gets a total amount of third spell [E] casts in game by this participant
        /// </summary>
        [JsonProperty("spell3Casts")]
        public int Spell3CastsCount { get; private set; }
        /// <summary>
        /// Gets a total amount of fourth spell [R] casts in game by this participant
        /// </summary>
        [JsonProperty("spell4Casts")]
        public int Spell4CastsCount { get; private set; }
        /// <summary>
        /// Gets a total amount of first summoner spell [D] casts in game by this participant
        /// </summary>
        [JsonProperty("summoner1Casts")]
        public int SummonerSpell1CastsCount { get; private set; }
        /// <summary>
        /// Gets a total amount of second summoner spell [F] casts in game by this participant
        /// </summary>
        [JsonProperty("summoner2Casts")]
        public int SummonerSpell2CastsCount { get; private set; }
        /// <summary>
        /// Gets an ID of summoner spell in first slot [D] of this participant
        /// </summary>
        [JsonProperty("summoner1Id")]
        public int SummonerSpell1Id { get; private set; }
        /// <summary>
        /// Gets an ID of summoner spell in second slot [F] of this participant
        /// </summary>
        [JsonProperty("summoner2Id")]
        public int SummonerSpell2Id { get; private set; }
        /// <summary>
        /// Gets a summoner level of this participant (League of Legends account level)
        /// </summary>
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; private set; }
        /// <summary>
        /// Gets a team ID of which team this participant was a part of 
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; private set; }
        /// <summary>
        /// Gets a total amount of damage dealt by champion of this participant
        /// </summary>
        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; private set; }
        /// <summary>
        /// Gets a total amount of damage dealt to only other champions by champion of this participant
        /// </summary>
        [JsonProperty("totalDamageDealtToChampions")]
        public int TotalDamageDealtToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of damage shielded on teammates by champion of this participant
        /// </summary>
        [JsonProperty("totalDamageShieldedOnTeammates")]
        public int TotalDamageShieldedOnTeammates { get; private set; }
        /// <summary>
        /// Gets a total amount of damage taken by champion of this participant (magic + physical + true) (premitigated?)
        /// </summary>
        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; private set; }
        /// <summary>
        /// Gets a total amount of healed damage by champion of this participant
        /// </summary>
        [JsonProperty("totalHeal")]
        public int TotalHeal { get; private set; }
        /// <summary>
        /// Gets a total amount of damage healed on teammates champions by champion of this participant
        /// </summary>
        [JsonProperty("totalHealsOnTeammates")]
        public int TotalHealsOnTeammates { get; private set; }
        /// <summary>
        /// Gets a total amount of minions killed on all lanes by this participant
        /// </summary>
        [JsonProperty("totalMinionsKilled")]
        public int TotalMinionsKilled { get; private set; }
        /// <summary>
        /// Gets a total amount of other champions this participant has healed in game
        /// </summary>
        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; private set; }
        /// <summary>
        /// Gets a total amount of triple kills made by this participant
        /// </summary>
        [JsonProperty("tripleKills")]
        public int Triplekills { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage dealt by champion of this participant
        /// </summary>
        [JsonProperty("trueDamageDealt")]
        public int TrueDamageDealt { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage dealt to only other champions by champion of this participant
        /// </summary>
        [JsonProperty("trueDamageDealtToChampions")]
        public int TrueDamageDealtToChampions { get; private set; }
        /// <summary>
        /// Gets a total amount of true damage taken by champion of this participant
        /// </summary>
        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; private set; }
        /// <summary>
        /// Gets a total amount of turret kills assists by this participant
        /// </summary>
        [JsonProperty("turretKills")]
        public int TurretKills { get; private set; }
        /// <summary>
        /// Gets a total amount of turrets killed by this participant
        /// </summary>
        [JsonProperty("turretTakedowns")]
        public int TurretTakedowns { get; private set; }
        /// <summary>
        /// Gets a total amount of turrets lost by the team of this participant
        /// </summary>
        [JsonProperty("turretsLost")]
        public int TurretsLost { get; private set; }
        /// <summary>
        /// Gets a total amount of hexa kills made by this participant
        /// </summary>
        [JsonProperty("unrealKills")]
        public int Unrealkills { get; private set; }
        /// <summary>
        /// Gets a total vision score achieved in game by this participant
        /// </summary>
        [JsonProperty("visionScore")]
        public int VisionScore { get; private set; }
        /// <summary>
        /// Gets a total amount of control wards bought in game by this participant
        /// </summary>
        [JsonProperty("visionWardsBought")]
        public int ControlWardsBought { get; private set; }
        /// <summary>
        /// Gets a total amount of wards destroyed in game by this participant
        /// </summary>
        [JsonProperty("wardsKilled")]
        public int WardsDestroyed { get; private set; }
        /// <summary>
        /// Gets a total amount of wards placed in game by this participant
        /// </summary>
        [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; private set; }

        /// <summary>
        /// Gets <see langword="true"/> if this participant eligible for progression
        /// </summary>
        [JsonProperty("eligibleForProgression")]
        public bool EligibleForProgression { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant assisted in getting first blood in game
        /// </summary>
        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant had a first blood in game
        /// </summary>
        [JsonProperty("firstBloodKill")]
        public bool FirstBlood { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant assisted in first tower destroyed in game
        /// </summary>
        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant destroyed first tower in game
        /// </summary>
        [JsonProperty("firstTowerKill")]
        public bool FirstTower { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if game of this participant ended in early surrender (before 20 minutes mark in game)
        /// </summary>
        [JsonProperty("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if game of this participant ended in surrender (after 20 minutes mark in game)
        /// </summary>
        [JsonProperty("gameEndedInSurrender")]
        public bool GameEndedInSurrender { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if team unanimously voted yes in early surrender (15-20 minute surrender, excluding AFK surrender)
        /// </summary>
        [JsonProperty("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this participant has won this game
        /// </summary>
        [JsonProperty("win")]
        public bool IsWonTheGame { get; private set; }

        /// <summary>
        /// Gets a champion name of this participant in game
        /// </summary>
        [JsonProperty("championName")]
        public string ChampionName { get; private set; }
        /// <summary>
        /// Gets a participant Riot Account PUUID
        /// </summary>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
        /// <summary>
        /// Gets a Riot Account Name for this participant
        /// </summary>
        /// <remarks>
        /// Currently returns an empty string
        /// </remarks>
        [JsonProperty("riotIdName")]
        public string RiotIdName { get; private set; }
        /// <summary>
        /// Gets a Riot Account Tag Line for this participant
        /// </summary>
        /// <remarks>
        /// Currently returns an empty string
        /// </remarks>
        [JsonProperty("riotIdTagline")]
        public string RiotIdTagline { get; private set; }
        /// <summary>
        /// Gets a League of Legends summoner ID for this participant
        /// </summary>
        [JsonProperty("summonerId")]
        public string SummonerId { get; private set; }
        /// <summary>
        /// Gets a League of Legends summoner account name for this participant
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; private set; }

        /// <summary>
        /// Gets a bounty level champion of this participant had upon game ending
        /// </summary>
        [JsonProperty("bountyLevel"), JsonConverter(typeof(LeagueBountyLevelConverter))]
        public LeagueBountyLevel BountyLevel { get; private set; }
        /// <summary>
        /// Gets a champion transform value for champion of this participant
        /// </summary>
        /// <remarks>
        /// Currently used only for Kayn transformations
        /// </remarks>
        [JsonProperty("championTransform"), JsonConverter(typeof(LeagueChampionTransformConverter))]
        public LeagueChampionTransform ChampionTransform { get; private set; }
        /// <summary>
        /// Gets a largest multi kill this participant made in game
        /// </summary>
        [JsonProperty("largestMultiKill"), JsonConverter(typeof(LeagueMultikillConverter))]
        public LeagueMultikill LargestMultiKill { get; private set; }
        /// <summary>
        /// Gets a League of Legends position on which this participant had played current game
        /// </summary>
        /// <remarks>
        /// This property represents the best guess for which position player is actually played in isolation of anything else <br/>
        /// General recommendation to use <see cref="TeamPosition"/> over this property
        /// </remarks>
        [JsonProperty("individualPosition"), JsonConverter(typeof(LeagueMatchPositionConverter))]
        public LeagueMatchPosition IndividualPosition { get; private set; }
        /// <summary>
        /// Gets a League of Legends position for which participant was queued for.
        /// </summary>
        /// <remarks>
        /// This property currently remains unclear due to lack of documentation from Riot Developer Page
        /// </remarks>
        [JsonProperty("lane"), JsonConverter(typeof(LeagueMatchPositionConverter))]
        public LeagueMatchPosition Lane { get; private set; }
        /// <summary>
        /// Gets a League of Legends position on which this participant had played current game adding all constraints
        /// </summary>
        /// <remarks>
        /// This property represents the best guess for which position is actually played with all added constraints <br/>
        /// such as each team must have one top lane player, one jungle, etc. <br/>
        /// General recommendation is to use this property over <see cref="IndividualPosition"/> property
        /// </remarks>
        [JsonProperty("teamPosition"), JsonConverter(typeof(LeagueMatchPositionConverter))]
        public LeagueMatchPosition TeamPosition { get; private set; }
        /// <summary>
        /// Gets a League of Legends role on which this participant played
        /// </summary>
        [JsonProperty("role"), JsonConverter(typeof(LeagueMatchRoleConverter))]
        public LeagueMatchRole Role { get; private set; }

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of time that participant remained living before dying
        /// </summary>
        [JsonProperty("longestTimeSpentLiving"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan LongestTimeSpentLiving { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of time that participant is played the game
        /// </summary>
        [JsonProperty("timePlayed"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan TimePlayed { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of total crowd control time dealt by champion of this participant to other champions
        /// </summary>
        [JsonProperty("totalTimeCCDealt"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan TotalCrowdControlTimeDealt { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of total time this participant spent seeing a gray screen (champion was dead)
        /// </summary>
        /// <remarks>
        /// It should be pretty high for participants who played Gray-Screen Simulator
        /// </remarks>
        [JsonProperty("totalTimeSpentDead"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan TotalTimeSpentDead { get; private set; }

        /// <summary>
        /// Gets a League of Legends rune set selected for this participant in game and all post-game data for these runes
        /// </summary>
        [JsonProperty("perks")]
        public LeagueChampionRunes Runes { get; private set; }
        /// <summary>
        /// Gets a changes of challenge progress for this participant
        /// </summary>
        [JsonProperty("challenges"), JsonConverter(typeof(KeyValuePairConverter))]
        public LeagueChallengesCollection ChallengesChanges { get; private set; } // challenges
    }
}
