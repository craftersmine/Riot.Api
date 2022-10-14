using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Riot.Api.League.SummonerLeagues
{
    public enum LeagueQueueType
    {
        RankedSoloDuo,
        RankedFlex,
        Unknown
    }

    public static class LeagueQueueTypeExtensions
    {
        internal const string RankedSoloDuoQueueId = "RANKED_SOLO_5x5";
        internal const string RankedFlexQueueId = "RANKED_FLEX_SR";

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
