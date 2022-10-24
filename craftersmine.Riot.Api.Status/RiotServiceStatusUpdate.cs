using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Service status update message
    /// </summary>
    public class RiotServiceStatusUpdate
    {
        [JsonProperty("publish_locations")]
        private string[] PublishLocationsStrings { get; set; }

        /// <summary>
        /// Gets an ID of status update message
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
        /// <summary>
        /// Gets an author name of status update message
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if this status update message was published
        /// </summary>
        [JsonProperty("publish")]
        public bool IsPublished { get; private set; }
        /// <summary>
        /// Gets a bitmask where status update message was published
        /// </summary>
        public RiotServiceStatusPublishLocations PublishLocations => ParsePublishLocationsFromStrings();
        /// <summary>
        /// Gets a <see cref="DateTime"/> of when this status update message was created
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> of when this status update message was updated
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; private set; }
        /// <summary>
        /// Gets a collection of localized messages for this status update message
        /// </summary>
        [JsonProperty("translations")]
        public RiotServiceStatusContentCollection Translations { get; private set; }

        private RiotServiceStatusPublishLocations ParsePublishLocationsFromStrings()
        {
            RiotServiceStatusPublishLocations flags = RiotServiceStatusPublishLocations.Unknown;
            foreach (var location in PublishLocationsStrings)
            {
                flags |= location.GetRiotServiceStatusPublishLocationsFromString();
            }

            return flags;
        }
    }
}
