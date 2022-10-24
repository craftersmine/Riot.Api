using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a collection of Riot Service Status messages
    /// </summary>
    public class RiotServiceStatusInfoCollection : List<RiotServiceStatusInfo>
    {
        /// <summary>
        /// Gets a Riot Service Status by specified ID
        /// </summary>
        /// <param name="id">ID of Riot Service Status</param>
        /// <returns><see cref="RiotServiceStatusInfo"/> with specified ID or <see langword="null"/></returns>
        public RiotServiceStatusInfo GetStatusInfoById(int id)
        {
            return this.FirstOrDefault(i => i.Id == id);
        }

        /// <summary>
        /// Gets an array of Riot Service Status messages with specified <see cref="RiotServiceIncidentSeverity"/>
        /// </summary>
        /// <param name="incidentSeverity">Riot Service incident severity</param>
        /// <returns>An array of <see cref="RiotServiceStatusInfo"/> with specified severity</returns>
        public RiotServiceStatusInfo[] GetStatusInfosWithSeverity(RiotServiceIncidentSeverity incidentSeverity)
        {
            List<RiotServiceStatusInfo> _infos = new List<RiotServiceStatusInfo>();
            foreach (var info in this)
            {
                if (info.IncidentSeverity == incidentSeverity)
                    _infos.Add(info);
            }

            return _infos.ToArray();
        }
    }
}
