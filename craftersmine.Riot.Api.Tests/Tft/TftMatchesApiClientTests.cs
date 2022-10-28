using craftersmine.Riot.Api.Common;
using craftesmine.Riot.Api.Tft.Summoner;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Tft.Matches;

namespace craftersmine.Riot.Api.Tests.Tft
{
    [TestClass]
    public class TftMatchesApiClientTests
    {
        public const string MatchId = "LA2_1233389909";
        public const string SummonerPuuid =
            "Y_dYnZOHRICBuA7rjUYGHpmXEcFrq2fjrJ-3k6NsJtGVH8dn0biO6ekUXC2PmDO1ZM-59VGGzlP62g";
        public const string Augment = "TFT7_Augment_GuardianTrait";
        public const string CompanionContentId = "c5a62aeb-1821-463b-a413-308814186744";
        public const string CompanionSpecies = "PetChibiKaisa";
        public const string TraitName = "Set7_Assassin";
        public const string UnitCharacterId = "TFT7_Malphite";
        public const string UnitItemName = "TFT_Item_TitanicHydra";
        public const int PatchMajor = 12;
        public const int PatchMinor = 20;
        public const int DataVersion = 5;
        public const int CompanionId = 45001;
        public const int CompanionSkinId = 1;
        public const int GoldLeft = 23;
        public const int LastRound = 37;
        public const int Level = 9;
        public const int Placement = 1;
        public const int PlayersEliminated = 1;
        public const int TotalDamageDealtToPlayers = 191;
        public const int TraitNumUnits = 1;
        public const int TraitTierCurrent = 0;
        public const int TraitTierTotal = 3;
        public const int UnitItemId = 27;
        public const int UnitRarity = 0;
        public const TftUnitTier UnitTier = TftUnitTier.Default;
        public const TftTraitStyle TraitStyle = TftTraitStyle.NoStyle;
        public readonly TimeSpan TimeEliminated = new TimeSpan(0, 36, 41);
        public const RiotRegion Region = RiotRegion.Americas;

        public RiotTftMatchesApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new RiotTftMatchesApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetMatchByIdTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            TftMatch match = await Client.GetMatchByIdAsync(Region, MatchId);
            Assert.IsTrue(match.Metadata.ParticipantIds.Any(), "No participants data found");
            Assert.IsTrue(match.Metadata.ParticipantIds.Contains(SummonerPuuid), "No specified summoner ID found");
            Assert.AreEqual(DataVersion, match.Metadata.DataVersion, "Data version is not 2");
            Assert.IsTrue(match.MatchInfo.GameVersion.Major == PatchMajor && match.MatchInfo.GameVersion.Minor == PatchMinor, "Game patch is not 12.20");
            Assert.AreEqual(1100, match.MatchInfo.QueueId, "Queue ID is not 1100");
            Assert.AreEqual("standard", match.MatchInfo.GameType, "Game type is not \"standard\"");
            Assert.AreEqual("TFTSet7_2", match.MatchInfo.SetCoreName, "Set core name is not \"TFTSet7_2\"");
            Assert.AreEqual(7, match.MatchInfo.SetNumber, "Set number is not 7");
            TftParticipant? participant = match.MatchInfo.Participants.FirstOrDefault(p => p.Puuid == SummonerPuuid);
            Assert.IsNotNull(participant, "Participant with specified PUUID is not found");
            Assert.IsTrue(participant.Augments.Any(), "No augments found");
            Assert.IsTrue(participant.Augments.Contains(Augment), "Specified augment is not found");
            Assert.IsNotNull(participant.Companion, "Participant's companion is null");
            Assert.AreEqual(CompanionContentId, participant.Companion.ContentId, "Companion content ID is not matched");
            Assert.AreEqual(CompanionId, participant.Companion.Id, "Companion ID is not matched");
            Assert.AreEqual(CompanionSkinId, participant.Companion.SkinId, "Companion skin ID is not matched");
            Assert.AreEqual(CompanionSpecies, participant.Companion.Species, "Companion species is not matched");
            Assert.AreEqual(GoldLeft, participant.GoldLeft, "Participant's gold left is not equal to " + GoldLeft);
            Assert.AreEqual(LastRound, participant.LastRound, "Participant's last round is not " + LastRound);
            Assert.AreEqual(Level, participant.Level, "Participant's level is not equal to " + Level);
            Assert.AreEqual(Placement, participant.Placement, "Participant's placement is not " + Placement);
            Assert.AreEqual(PlayersEliminated, participant.PlayersEliminated, "Eliminated by participant value is not " + PlayersEliminated);
            Assert.AreEqual(TotalDamageDealtToPlayers, participant.TotalDamageDealtToPlayers);
            Assert.IsTrue(participant.Traits.Any(), "No traits found");
            TftTrait? trait = participant.Traits.FirstOrDefault(t => t.Name == TraitName);
            Assert.IsNotNull(trait, "Trait is not found");
            Assert.AreEqual(TraitName, trait.Name, "Trait name is not " + TraitName);
            Assert.AreEqual(TraitNumUnits, trait.NumberOfUnits, "Trait's number of units is not " + TraitNumUnits);
            Assert.AreEqual(TraitStyle, trait.Style, "Trait style is not " + TraitStyle);
            Assert.AreEqual(TraitTierCurrent, trait.TierCurrent, "Current trait tier is not " + trait.TierCurrent);
            Assert.AreEqual(TraitTierTotal, trait.TierTotal, "Total trait tier is not " + TraitTierTotal);
            Assert.IsTrue(participant.Units.Any(), "No units found");
            TftUnit? unit = participant.Units.FirstOrDefault(u => u.CharacterId == UnitCharacterId);
            Assert.IsNotNull(unit, "Unit is not found");
            Assert.IsTrue(unit.ItemNames.Any(), "No unit item names fetched");
            Assert.IsTrue(unit.ItemNames.Contains(UnitItemName), "No unit item name found with value: " + UnitItemId);
            Assert.IsTrue(unit.ItemsIds.Any(), "No unit item IDs fetched");
            Assert.IsTrue(unit.ItemsIds.Contains(UnitItemId), "No item ID found with value: " + UnitItemId);
            Assert.AreEqual(UnitRarity, unit.Rarity, "Unit's rarity is not " + UnitRarity);
            Assert.AreEqual(UnitTier, unit.Tier, "Unit's tier is not " + UnitTier);
        }
    }
}
