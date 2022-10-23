using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a Riot Service incident severity
    /// </summary>
    public enum RiotServiceIncidentSeverity
    {
        /// <summary>
        /// Unknown incident severity
        /// </summary>
        Unknown,
        /// <summary>
        /// Informational message
        /// </summary>
        Informational,
        /// <summary>
        /// Non-critical issue that causing some problems
        /// </summary>
        Warning,
        /// <summary>
        /// Critical issue or full service outage
        /// </summary>
        Critical
    }
    
    /// <summary>
    /// Contains static extension methods for <see cref="RiotServiceIncidentSeverity"/>
    /// </summary>
    public static class RiotServiceIncidentSeverityExtensions
    {
        private const string Informational = "info";
        private const string Warning = "warning";
        private const string Critical = "critical";
        
        /// <summary>
        /// Gets corresponding string for <see cref="RiotServiceIncidentSeverity"/> value
        /// </summary>
        /// <param name="incidentSeverity">Riot Service maintenance status</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="RiotServiceIncidentSeverity"/> value</returns>
        /// <exception cref="ArgumentException">When unknown value is selected</exception>
        public static string GetStringFor(this RiotServiceIncidentSeverity incidentSeverity)
        {
            switch (incidentSeverity)
            {
                case RiotServiceIncidentSeverity.Informational:
                    return Informational;
                case RiotServiceIncidentSeverity.Warning:
                    return Warning;
                case RiotServiceIncidentSeverity.Critical:
                    return Critical;
                case RiotServiceIncidentSeverity.Unknown:
                default:
                    throw new ArgumentException("Unknown value selected for incident severity",
                        nameof(incidentSeverity));
            }
        }

        internal static RiotServiceIncidentSeverity GetRiotServiceIncidentSeverityFromString(this string str)
        {
            switch (str)
            {
                case Informational:
                    return RiotServiceIncidentSeverity.Informational;
                case Warning:
                    return RiotServiceIncidentSeverity.Warning;
                case Critical:
                    return RiotServiceIncidentSeverity.Critical;
                default:
                    return RiotServiceIncidentSeverity.Unknown;
            }
        }
    }
}
