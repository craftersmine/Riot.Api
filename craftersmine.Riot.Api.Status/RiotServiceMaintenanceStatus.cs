using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Service maintenance status
    /// </summary>
    public enum RiotServiceMaintenanceStatus
    {
        /// <summary>
        /// Maintenance status is unknown
        /// </summary>
        Unknown,
        /// <summary>
        /// Maintenance is scheduled on this service
        /// </summary>
        Scheduled,
        /// <summary>
        /// Maintenance is currently being done on this service
        /// </summary>
        InProgress,
        /// <summary>
        /// Maintenance is done on this service
        /// </summary>
        Complete
    }

    /// <summary>
    /// Contains static extension methods for <see cref="RiotServiceMaintenanceStatus"/>
    /// </summary>
    public static class RiotServiceMaintenanceStatusExtensions
    {
        private const string Scheduled = "scheduled";
        private const string InProgress = "in_progress";
        private const string Complete = "complete";

        /// <summary>
        /// Gets corresponding string for <see cref="RiotServiceMaintenanceStatus"/> value
        /// </summary>
        /// <param name="maintenanceStatus">Riot Service maintenance status</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RiotServiceMaintenanceStatus"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RiotServiceMaintenanceStatus maintenanceStatus)
        {
            switch (maintenanceStatus)
            {
                case RiotServiceMaintenanceStatus.Scheduled:
                    return Scheduled;
                case RiotServiceMaintenanceStatus.InProgress:
                    return InProgress;
                case RiotServiceMaintenanceStatus.Complete:
                    return Complete;
                default:
                    throw new ArgumentException("Unknown value selected for maintenance status",
                        nameof(maintenanceStatus));
            }
        }

        internal static RiotServiceMaintenanceStatus GetRiotServiceMaintenanceStatusFromString(this string str)
        {
            switch (str)
            {
                case Scheduled:
                    return RiotServiceMaintenanceStatus.Scheduled;
                case InProgress:
                    return RiotServiceMaintenanceStatus.InProgress;
                case Complete:
                    return RiotServiceMaintenanceStatus.Complete;
                default:
                    return RiotServiceMaintenanceStatus.Unknown;
            }
        }
    }
}
