using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Tests.Common
{
    [TestClass]
    public class RiotApiClientSettingsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRiotApiClientSettings settings = new RiotApiClientSettingsBuilder().UseApiKey("asfjgdjdagsp")
                .UseTournamentStub().Build();
        }
    }
}