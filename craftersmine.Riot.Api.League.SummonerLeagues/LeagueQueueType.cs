using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    /// <summary>
    /// Represents a League of Legends ranked queue
    /// </summary>
    public enum LeagueQueueType
    {
        /// <summary>
        /// League of Legends Ranked Solo/Duo queues
        /// </summary>
        RankedSoloDuo,
        /// <summary>
        /// League of Legends Ranked Flex queues
        /// </summary>
        RankedFlex,
        /// <summary>
        /// Unknown queues
        /// </summary>
        Unknown
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="LeagueQueueType"/> enum extensions
    /// </summary>
    public static class LeagueQueueTypeExtensions
    {
        internal const string RankedSoloDuoQueueId = "RANKED_SOLO_5x5";
        internal const string RankedFlexQueueId = "RANKED_FLEX_SR";

        /// <summary>
        /// Gets a representing string for <see cref="LeagueQueueType"/>
        /// </summary>
        /// <param name="queueType">League of Legends queue type</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetLeagueQueueStringFor(this LeagueQueueType queueType)
        {
            switch (queueType)
            {
                case LeagueQueueType.RankedSoloDuo:
                    return RankedSoloDuoQueueId;
                case LeagueQueueType.RankedFlex:
                    return RankedFlexQueueId;
                default:
                    throw new ArgumentException("Unknown League of Legends Queue type selected!");
            }
        }

        internal static LeagueQueueType GetLeagueQueueTypeFromString(this string str)
        {
            switch (str)
            {
                case RankedSoloDuoQueueId:
                    return LeagueQueueType.RankedSoloDuo;
                case RankedFlexQueueId:
                    return LeagueQueueType.RankedFlex;
                default:
                    return LeagueQueueType.Unknown;
            }
        }
    }
}
