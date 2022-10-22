using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Status.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Service Status information
    /// </summary>
    public class RiotServiceStatusInfo
    {
        [JsonProperty("platforms")]
        private string[] PlatformsStrings { get; set; }

        /// <summary>
        /// Gets an ID of Riot Service status information
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> when this status information was created
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> when this status information will be or was archived
        /// </summary>
        [JsonProperty("archive_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime ArchiveAt { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> when this status information was updated
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; private set; }
        /// <summary>
        /// Gets a current Riot Service maintenance status
        /// </summary>
        [JsonProperty("maintenance_status"), JsonConverter(typeof(RiotServiceMaintenanceStatusConverter))]
        public RiotServiceMaintenanceStatus MaintenanceStatus { get; private set; }
        /// <summary>
        /// Gets a current Riot Service incident severity level
        /// </summary>
        [JsonProperty("incident_severity"), JsonConverter(typeof(RiotServiceIncidentSeverityConverter))]
        public RiotServiceIncidentSeverity IncidentSeverity { get; private set; }
        /// <summary>
        /// Gets a bitmask of affected platforms with this status
        /// </summary>
        public RiotServiceStatusPlatform Platforms => ParsePlatformsStringsToFlags();
        /// <summary>
        /// Gets a Riot Service status updates
        /// </summary>
        [JsonProperty("updates")]
        public RiotServiceStatusUpdateCollection Updates { get; private set; }
        /// <summary>
        /// Gets a Riot Service localized status titles for this status
        /// </summary>
        [JsonProperty("titles")]
        public RiotServiceStatusContentCollection Titles { get; private set; }

        private RiotServiceStatusPlatform ParsePlatformsStringsToFlags()
        {
            RiotServiceStatusPlatform flags = RiotServiceStatusPlatform.Unknown;
            foreach (var platform in PlatformsStrings)
            {
                flags |= platform.GetRiotServicePlatformFromString();
            }

            return flags;
        }
    }
}
