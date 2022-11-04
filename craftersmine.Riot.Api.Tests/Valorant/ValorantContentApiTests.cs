using craftersmine.Riot.Api.Common;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Valorant.Content;

namespace craftersmine.Riot.Api.Tests.Valorant
{
    [TestClass]
    public class ValorantContentApiTests
    {
        public const string ValorantContentVersion = "release-05.08";

        public const string CurrentActName = "ACT 3";
        public const string CurrentActLocalizedName = "АКТ 3";
        public const string CurrentEpisodeName = "EPISODE 5";
        public const string CurrentEpisodeLocalizedName = "ЭПИЗОД 5";

        public const string CharacterNeutralName = "Breach";
        public const string CharacterLocalizedName = "Breach";
        public const string CharacterAssetName = "Default__Breach_PrimaryAsset_C";

        public const string MapNeutralName = "Ascent";
        public const string MapLocalizedName = "Ascent";
        public const string MapAssetName = "Ascent";
        public const string MapAssetPath = "/Game/Maps/Ascent/Ascent";

        public readonly Guid CurrentActId = new Guid("aca29595-40e4-01f5-3f35-b1b3d304c96e");
        public readonly Guid CurrentActParentId = new Guid("79f9d00f-433a-85d6-dfc3-60aef115e699");
        public readonly Guid CurrentEpisodeId = new Guid("79f9d00f-433a-85d6-dfc3-60aef115e699");

        public readonly Guid CharacterId = new Guid("5F8D3A7F-467B-97F3-062C-13ACF203C006");

        public readonly Guid MapId = new Guid("7EAECC1B-4337-BBF6-6AB9-04B8F06B3319");

        public readonly CultureInfo Locale = new CultureInfo("ru-RU");

        public ValorantContentApiClient? Client { get; set; }
        public string? ApiKey { get; set; }

        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ApiKey = TestContext?.Properties["ApiKey"]?.ToString();
            if (string.IsNullOrWhiteSpace(ApiKey))
                Assert.Fail("No Riot API key provided!");
            Client = new ValorantContentApiClient(new RiotApiClientSettingsBuilder().UseApiKey(ApiKey).Build());
        }

        [TestMethod]
        public async Task GetContentTests()
        {
            Assert.IsNotNull(Client, "Client is not initialized!");
            ValorantContent content = await Client.GetContentData();
            Assert.IsFalse(string.IsNullOrWhiteSpace(content.Version), "No acts are fetched");
            Assert.AreEqual(ValorantContentVersion, content.Version, "Versions are not matched");

            Assert.IsTrue(content.Acts.Any(), "No acts are fetched");
            Assert.IsTrue(content.Ceremonies.Any(), "No ceremonies are fetched");
            Assert.IsTrue(content.Characters.Any(), "No characters are fetched");
            Assert.IsTrue(content.Charms.Any(), "No charms are fetched");
            Assert.IsTrue(content.CharmsLevels.Any(), "No charms levels are fetched");
            Assert.IsTrue(content.Chromas.Any(), "No chromas are fetched");
            Assert.IsTrue(content.Equips.Any(), "No equips are fetched");
            Assert.IsTrue(content.GameModes.Any(), "No game modes are fetched");
            Assert.IsTrue(content.Maps.Any(), "No maps are fetched");
            Assert.IsTrue(content.PlayerCards.Any(), "No player cards are fetched");
            Assert.IsTrue(content.PlayerTitles.Any(), "No player titles are fetched");
            Assert.IsTrue(content.SkinLevels.Any(), "No skin levels are fetched");
            Assert.IsTrue(content.Skins.Any(), "No skins are fetched");

            ValorantAct? act = content.Acts.FirstOrDefault(a => a.Id == CurrentActId);
            Assert.IsNotNull(act, "No current act fetched with specified ID");
            Assert.AreEqual(ValorantActType.Act, act.Type, "Act type is not \"act\"");
            Assert.IsTrue(act.IsActive, "Current act is not active");
            Assert.AreEqual(CurrentActId, act.Id, "IDs are not matched");
            Assert.AreEqual(CurrentActParentId, act.ParentId, "Parent IDs are not matched");
            Assert.AreEqual(CurrentActName, act.Name, "Act name are not matched");
            Assert.IsTrue(act.LocalizedNames.Any(), "No localized names fetched for act");
            string actLocalizedName = act.LocalizedNames[Locale];
            Assert.IsFalse(string.IsNullOrWhiteSpace(actLocalizedName), "No localized name for ru-RU is fetched for act");
            Assert.AreEqual(CurrentActLocalizedName, actLocalizedName, "Act localized names are not matched");

            ValorantAct? episode = content.Acts.FirstOrDefault(a => a.Id == CurrentEpisodeId);
            Assert.IsNotNull(episode, "No current episode fetched with specified ID");
            Assert.AreEqual(ValorantActType.Episode, episode.Type, "Episode type is not \"episode\"");
            Assert.IsTrue(episode.IsActive, "Current episode is not active");
            Assert.AreEqual(CurrentEpisodeId, episode.Id, "IDs are not matched");
            Assert.AreEqual(Guid.Empty, episode.ParentId, "Parent IDs are not matched");
            Assert.AreEqual(CurrentEpisodeName, episode.Name, "Episode name are not matched");
            Assert.IsTrue(episode.LocalizedNames.Any(), "No localized names fetched for episode");
            string episodeLocalizedName = episode.LocalizedNames[Locale];
            Assert.IsFalse(string.IsNullOrWhiteSpace(episodeLocalizedName), "No localized name for ru-RU is fetched for episode");
            Assert.AreEqual(CurrentEpisodeLocalizedName, episodeLocalizedName, "Episode localized names are not matched");

            ValorantContentItem? character = content.Characters.FirstOrDefault(c => c.Id == CharacterId);
            Assert.IsNotNull(character, "Character with specified ID is not fetched");
            Assert.AreEqual(CharacterId, character.Id, "Character IDs are not matched");
            Assert.AreEqual(CharacterNeutralName, character.Name, "Character neutral names are not matched");
            Assert.AreEqual(CharacterAssetName, character.AssetName, "Character asset names are not matched");
            Assert.IsTrue(character.LocalizedNames.Any(), "No character localized names are fetched");
            string charLocalizedName = character.LocalizedNames[Locale];
            Assert.IsFalse(string.IsNullOrWhiteSpace(charLocalizedName), "Character localized name string is empty or null");
            Assert.AreEqual(CharacterLocalizedName, charLocalizedName, "Character localized name strings are not matched");

            ValorantContentItem? map = content.Maps.FirstOrDefault(m => m.Id == MapId);
            Assert.IsNotNull(map, "Map with specified ID is not fetched");
            Assert.AreEqual(MapId, map.Id, "Map IDs are not matched");
            Assert.AreEqual(MapNeutralName, map.Name, "Map neutral names are not matched");
            Assert.AreEqual(MapAssetName, map.AssetName, "Map asset names are not matched");
            Assert.AreEqual(MapAssetPath, map.AssetPath, "Map asset paths are not matched");
            Assert.IsTrue(map.LocalizedNames.Any(), "No map localized names are fetched");
            string mapLocalizedName = map.LocalizedNames[Locale];
            Assert.IsFalse(string.IsNullOrWhiteSpace(mapLocalizedName), "Map localized name is null or empty");
            Assert.AreEqual(MapLocalizedName, mapLocalizedName, "Map localized names strings are not matched");

        }
    }
}
