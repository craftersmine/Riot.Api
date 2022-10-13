using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Tests.Common
{
    [TestClass]
    public class RiotApiClientSettingsTests
    {
        [TestMethod]
        public void RiotApiClientSettingsBuilderTester()
        {
            RiotApiClientSettings settings = new RiotApiClientSettingsBuilder().UseApiKey("RGAPI-f6353ed0-89f4-4c03-bc01-e383a23166d0") // This is randomly generated GUID instead of real Riot API key
                .UseTournamentStub().Build();
        }
    }
}