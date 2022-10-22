using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.Status.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Service Status information
    /// </summary>
    public class RiotServiceStatus
    {
        [JsonProperty("locales")]
        private string[] ServerLocalesStrings { get; set; }

        /// <summary>
        /// Gets a Riot Games Platform ID on which incident happened
        /// </summary>
        [JsonProperty("id"), JsonConverter(typeof(RiotServicePlatformConverter))]
        public RiotServicePlatform ServerId { get; private set; }
        /// <summary>
        /// Gets a human-readable name of affected server
        /// </summary>
        [JsonProperty("name")] public string ServerName { get; private set; }
        /// <summary>
        /// Gets an array of <see cref="CultureInfo"/> of available messages localizations
        /// </summary>
        public CultureInfo[] ServerLocales => GetCultureInfosFromLocalesStrings();
        /// <summary>
        /// Gets a collection of currently ongoing maintenances
        /// </summary>
        [JsonProperty("maintenances")]
        public RiotServiceStatusInfoCollection Maintenances { get; private set; }
        /// <summary>
        /// Gets a collection of current incidents which are not currently resolved
        /// </summary>
        [JsonProperty("incidents")]
        public RiotServiceStatusInfoCollection Incidents { get; private set; }

        private CultureInfo[] GetCultureInfosFromLocalesStrings()
        {
            List<CultureInfo> _cultureInfos = new List<CultureInfo>();
            foreach (var locale in ServerLocalesStrings)
            {
                _cultureInfos.Add(new CultureInfo(locale.Replace('_', '-')));
            }

            return _cultureInfos.ToArray();
        }
    }
}
