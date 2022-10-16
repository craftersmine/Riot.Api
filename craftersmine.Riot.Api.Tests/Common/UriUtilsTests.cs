using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Tests.Common
{
    [TestClass]
    public class UriUtilsTests
    {
        [TestMethod]
        public void GetAddressTests()
        {
            string value = string.Empty;

            value = UriUtils.GetAddress(RiotPlatform.Russia, "/riot/account/v1/accounts/");
            Assert.AreEqual(Constants.BaseAddressPlatformRu + "riot/account/v1/accounts/", value);

            value = UriUtils.GetAddress(RiotRegion.Europe, "/riot/account/v1/accounts/");
            Assert.AreEqual(Constants.BaseAddressRegionEurope + "riot/account/v1/accounts/", value);
        }

        [TestMethod]
        public void JoinEndpointsTests()
        {
            string value = string.Empty;

            value = UriUtils.JoinEndpoints("/riot/account", "/v1/", "accounts/");
            Assert.AreEqual("/riot/account/v1/accounts", value);

            value = UriUtils.JoinEndpoints("/riot/account/v1/accounts/", "by-puuid", "aaabbbccc...");
            Assert.AreEqual("/riot/account/v1/accounts/by-puuid/aaabbbccc...", value);
        }
    }
}
