using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a collection of Riot Service status updates
    /// </summary>
    public class RiotServiceStatusUpdateCollection : List<RiotServiceStatusUpdate>
    {
        /// <summary>
        /// Gets an array of Riot Service status updates that were published at specified locations
        /// </summary>
        /// <param name="publishLocations">Bitmask of <see cref="RiotServiceStatusPublishLocations"/></param>
        /// <returns>An array of <see cref="RiotServiceStatusUpdate"/> that were published at <see cref="RiotServiceStatusPublishLocations"/></returns>
        public RiotServiceStatusUpdate[] GetUpdatesForPublishLocations(RiotServiceStatusPublishLocations publishLocations)
        {
            List<RiotServiceStatusUpdate> _updates = new List<RiotServiceStatusUpdate>();
            foreach (var update in this)
            {
                if (update.PublishLocations.HasFlag(publishLocations))
                    _updates.Add(update);
            }

            return _updates.ToArray();
        }
    }
}
