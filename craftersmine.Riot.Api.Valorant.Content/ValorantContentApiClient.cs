using craftersmine.Riot.Api.Common;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Valorant.Content
{
    public class ValorantContentApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/val/content/v1";

        public ValorantContentApiClient(RiotApiClientSettings settings) : base(settings) { }

        public async Task<ValorantContent> GetContentData(string locale)
        {
            if (string.IsNullOrWhiteSpace(locale))
                throw new ArgumentNullException(nameof(locale));

            string endpoint = UriUtils.GetAddress(Settings.DefaultValorantContentShard,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "contents"));

            ValorantContent valContent =
                await Client.GetAsync<ValorantContent>(endpoint, new Dictionary<string, object>() { { "locale", locale } });
            return valContent;
        }

        public async Task<ValorantContent> GetContentData(CultureInfo locale)
        {
            if (locale is null)
                throw new ArgumentNullException(nameof(locale));
            return await GetContentData(locale.Name);
        }

        public async Task<ValorantContent> GetContentData()
        {
            string endpoint = UriUtils.GetAddress(Settings.DefaultValorantContentShard,
                UriUtils.JoinEndpoints(ApiEndpointRoot, "contents"));

            ValorantContent valContent =
                await Client.GetAsync<ValorantContent>(endpoint, null);
            return valContent;
        }
    }
}
