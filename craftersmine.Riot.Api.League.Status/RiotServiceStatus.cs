using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Status
{
    public class RiotServiceStatus
    {
        [JsonProperty("locales")]
        private string[] ServerLocalesStrings { get; set; }
        [JsonProperty("id"), JsonConverter(typeof(RiotPlatformAsLeagueRegionConverter))]
        public RiotPlatform ServerId { get; private set; }
        [JsonProperty("name")] public string ServerName { get; private set; }
        public CultureInfo[] ServerLocales => GetCultureInfosFromLocalesStrings();
        [JsonProperty("maintenances")]
        public RiotServiceStatusInfoCollection Maintenances { get; private set; }
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
