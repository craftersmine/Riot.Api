using craftersmine.Riot.Api.Common;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.Valorant.Content
{
    /// <summary>
    /// Represents Riot Valorant Content v1 API
    /// </summary>
    public class ValorantContentApiClient : RiotApiClient
    {
        private const string ApiEndpointRoot = "/val/content/v1";
        
        /// <summary>
        /// Creates new instance of <see cref="ValorantContentApiClient"/> with specified settings
        /// </summary>
        /// <param name="settings">Settings for <see cref="ValorantContentApiClient"/></param>
        public ValorantContentApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Gets current Valorant Content metadata
        /// </summary>
        /// <param name="locale">Filter locale for specified locale</param>
        /// <returns>Valorant Content metadata</returns>
        /// <exception cref="ArgumentNullException">When locale is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
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

        /// <inheritdoc cref="GetContentData(string)"/>
        public async Task<ValorantContent> GetContentData(CultureInfo locale)
        {
            if (locale is null)
                throw new ArgumentNullException(nameof(locale));
            return await GetContentData(locale.Name);
        }

        /// <inheritdoc cref="GetContentData(string)"/>
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
