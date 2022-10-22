using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;

namespace craftersmine.Riot.Api.Status
{
    public enum RiotServicePlatform
    {
        /// <inheritdoc cref="Common.RiotPlatform.Brazil"/>
        LeagueBr1,
        /// <inheritdoc cref="Common.RiotPlatform.EuropeNordicEast"/>
        LeagueEun1,
        /// <inheritdoc cref="Common.RiotPlatform.EuropeWest"/>
        LeagueEuw1,
        /// <inheritdoc cref="Common.RiotPlatform.LatinAmericaNorth"/>
        LeagueLa1,
        /// <inheritdoc cref="Common.RiotPlatform.LatinAmericaSouth"/>
        LeagueLa2,
        /// <inheritdoc cref="Common.RiotPlatform.NorthAmerica"/>
        LeagueNa1,
        /// <inheritdoc cref="Common.RiotPlatform.Oceania"/>
        LeagueOc1,
        /// <inheritdoc cref="Common.RiotPlatform.Russia"/>
        LeagueRu,
        /// <inheritdoc cref="Common.RiotPlatform.Turkey"/>
        LeagueTr1,
        /// <inheritdoc cref="Common.RiotPlatform.Japan"/>
        LeagueJp1,
        /// <inheritdoc cref="Common.RiotPlatform.Korea"/>
        LeagueKr,
        /// <summary>
        /// Public Beta Environment server
        /// </summary>
        LeaguePbe,
        /// <inheritdoc cref="Common.RiotShards.ValorantEurope"/>
        ValorantEurope,
        /// <inheritdoc cref="Common.RiotShards.ValorantNorthAmerica"/>
        ValorantNorthAmerica,
        /// <inheritdoc cref="Common.RiotShards.ValorantLatinAmerica"/>
        ValorantLatinAmerica,
        /// <inheritdoc cref="Common.RiotShards.ValorantKorea"/>
        ValorantKorea,
        /// <inheritdoc cref="Common.RiotShards.ValorantBrazil"/>
        ValorantBrazil,
        /// <inheritdoc cref="Common.RiotShards.ValorantAsiaPacific"/>
        ValorantAsiaPacific,
        /// <inheritdoc cref="Common.RiotShards.LoREurope"/>
        LoREurope,
        /// <inheritdoc cref="Common.RiotShards.LoRAmericas"/>
        LoRAmericas,
        /// <inheritdoc cref="Common.RiotShards.LoRAsiaPacific"/>
        LoRAsiaPacific
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="RiotServicePlatform"/> enum extensions
    /// </summary>
    public static class RiotServicePlatformExtensions
    {
        /// <summary>
        /// Gets a representing string for <see cref="RiotServicePlatform"/> value
        /// </summary>
        /// <param name="platform"><see cref="RiotServicePlatform"/> value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetStringFor(this RiotServicePlatform platform)
        {
            switch (platform)
            {
                case RiotServicePlatform.LeagueBr1:
                    return Constants.LolBr1Region;
                case RiotServicePlatform.LeagueEun1:
                    return Constants.LolEun1Region;
                case RiotServicePlatform.LeagueEuw1:
                    return Constants.LolEuw1Region;
                case RiotServicePlatform.LeagueLa1:
                    return Constants.LolLa1Region;
                case RiotServicePlatform.LeagueLa2:
                    return Constants.LolLa2Region;
                case RiotServicePlatform.LeagueNa1:
                    return Constants.LolNa1Region;
                case RiotServicePlatform.LeagueOc1:
                    return Constants.LolOc1Region;
                case RiotServicePlatform.LeagueRu:
                    return Constants.LolRuRegion;
                case RiotServicePlatform.LeagueTr1:
                    return Constants.LolTr1Region;
                case RiotServicePlatform.LeagueJp1:
                    return Constants.LolJp1Region;
                case RiotServicePlatform.LeagueKr:
                    return Constants.LolKrRegion;
                case RiotServicePlatform.LeaguePbe:
                    return Constants.LolPbe1Region;
                case RiotServicePlatform.ValorantEurope:
                    return Constants.ShardValorantEurope;
                case RiotServicePlatform.ValorantNorthAmerica:
                    return Constants.ShardValorantNorthAmerica;
                case RiotServicePlatform.ValorantLatinAmerica:
                    return Constants.ShardValorantLatinAmerica;
                case RiotServicePlatform.ValorantKorea:
                    return Constants.ShardValorantKorea;
                case RiotServicePlatform.ValorantBrazil:
                    return Constants.ShardValorantBrazil;
                case RiotServicePlatform.ValorantAsiaPacific:
                    return Constants.ShardValorantAsiaPacific;
                case RiotServicePlatform.LoREurope:
                    return Constants.ShardLoREurope;
                case RiotServicePlatform.LoRAmericas:
                    return Constants.ShardLoRAmericas;
                case RiotServicePlatform.LoRAsiaPacific:
                    return Constants.ShardLoRAsiaPacific;
                default:
                    throw new ArgumentException("Unknown value selected for service platform", nameof(platform));
            }
        }

        internal static RiotServicePlatform GetRiotServicePlatformFromString(this string str)
        {
            switch (str)
            {
                case Constants.LolBr1Region:
                    return RiotServicePlatform.LeagueBr1;
                case Constants.LolEun1Region:
                    return RiotServicePlatform.LeagueEun1;
                case Constants.LolEuw1Region:
                    return RiotServicePlatform.LeagueEuw1;
                case Constants.LolLa1Region:
                    return RiotServicePlatform.LeagueLa1;
                case Constants.LolLa2Region:
                    return RiotServicePlatform.LeagueLa2;
                case Constants.LolNa1Region:
                    return RiotServicePlatform.LeagueNa1;
                case Constants.LolOc1Region:
                    return RiotServicePlatform.LeagueOc1;
                case Constants.LolRuRegion:
                    return RiotServicePlatform.LeagueRu;
                case Constants.LolTr1Region:
                    return RiotServicePlatform.LeagueTr1;
                case Constants.LolJp1Region:
                    return RiotServicePlatform.LeagueJp1;
                case Constants.LolKrRegion:
                    return RiotServicePlatform.LeagueKr;
                case Constants.LolPbe1Region:
                    return RiotServicePlatform.LeaguePbe;
                case Constants.ShardValorantEurope:
                    return RiotServicePlatform.ValorantEurope;
                case Constants.ShardValorantNorthAmerica:
                    return RiotServicePlatform.ValorantNorthAmerica;
                case Constants.ShardValorantLatinAmerica:
                    return RiotServicePlatform.ValorantLatinAmerica;
                case Constants.ShardValorantKorea:
                    return RiotServicePlatform.ValorantKorea;
                case Constants.ShardValorantBrazil:
                    return RiotServicePlatform.ValorantBrazil;
                case Constants.ShardValorantAsiaPacific:
                    return RiotServicePlatform.ValorantAsiaPacific;
                case Constants.ShardLoREurope:
                    return RiotServicePlatform.LoREurope;
                case Constants.ShardLoRAmericas:
                    return RiotServicePlatform.LoRAmericas;
                case Constants.ShardLoRAsiaPacific:
                    return RiotServicePlatform.LoRAsiaPacific;
                default:
                    throw new ArgumentException("Unknown Riot service platform string: " + str, nameof(str));
            }
        }
    }
}
