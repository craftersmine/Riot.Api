using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Status.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Status
{
    public class RiotServiceStatusInfo
    {
        [JsonProperty("platforms")]
        private string[] PlatformsStrings { get; set; }

        [JsonProperty("id")]
        public int Id { get; private set; }
        [JsonProperty("created_at"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }
        [JsonProperty("archive_at"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ArchiveAt { get; private set; }
        [JsonProperty("updated_at"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }
        [JsonProperty("maintenance_status"), JsonConverter(typeof(RiotServiceMaintenanceStatusConverter))]
        public RiotServiceMaintenanceStatus MaintenanceStatus { get; private set; }
        [JsonProperty("incident_severity"), JsonConverter(typeof(RiotServiceIncidentSeverityConverter))]
        public RiotServiceIncidentSeverity IncidentSeverity { get; private set; }
        public RiotServicePlatform Platforms => ParsePlatformsStringsToFlags();
        [JsonProperty("updates")]
        public RiotServiceStatusUpdateCollection Updates { get; private set; }
        [JsonProperty("titles")]
        public RiotServiceStatusTitleCollection Titles { get; private set; }

        public RiotServicePlatform ParsePlatrformsStringsToFlags()
        {
            throw new NotImplementedException();
        }
    }
}
