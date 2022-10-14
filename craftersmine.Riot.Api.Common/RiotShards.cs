using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Exceptions;

namespace craftersmine.Riot.Api.Common
{
    public enum RiotShards
    {
        Unknown,
        LoREurope,
        LoRAmericas,
        LoRAsiaPacific,
        ValorantEurope,
        ValorantNorthAmerica,
        ValorantLatinAmerica,
        ValorantKorea,
        ValorantBrazil,
        ValorantAsiaPacific
    }

    public static class RiotShardsExtensions
    {
        public static string GetShardString(this RiotShards shard)
        {
            switch (shard)
            {
                case RiotShards.LoREurope:
                    return Constants.ShardLoREurope;
                case RiotShards.LoRAmericas:
                    return Constants.ShardLoRAmericas;
                case RiotShards.LoRAsiaPacific:
                    return Constants.ShardLoRAsiaPacific;
                case RiotShards.ValorantEurope:
                    return Constants.ShardValorantEurope;
                case RiotShards.ValorantNorthAmerica:
                    return Constants.ShardValorantNorthAmerica;
                case RiotShards.ValorantLatinAmerica:
                    return Constants.ShardValorantLatinAmerica;
                case RiotShards.ValorantKorea:
                    return Constants.ShardValorantKorea;
                case RiotShards.ValorantBrazil:
                    return Constants.ShardValorantBrazil;
                case RiotShards.ValorantAsiaPacific:
                    return Constants.ShardValorantAsiaPacific;
                default:
                    throw new ArgumentException("Unknown Riot Active Shard ID selected!", nameof(shard));
            }
        }

        internal static RiotShards GetShardFromString(this string str)
        {
            switch (str.ToLower())
            {
                case Constants.ShardLoREurope:
                    return RiotShards.LoREurope;
                case Constants.ShardLoRAmericas:
                    return RiotShards.LoRAmericas;
                case Constants.ShardLoRAsiaPacific:
                    return RiotShards.LoRAsiaPacific;
                case Constants.ShardValorantEurope:
                    return RiotShards.ValorantEurope;
                case Constants.ShardValorantNorthAmerica:
                    return RiotShards.ValorantNorthAmerica;
                case Constants.ShardValorantLatinAmerica:
                    return RiotShards.ValorantLatinAmerica;
                case Constants.ShardValorantKorea:
                    return RiotShards.ValorantKorea;
                case Constants.ShardValorantBrazil:
                    return RiotShards.ValorantBrazil;
                case Constants.ShardValorantAsiaPacific:
                    return RiotShards.ValorantAsiaPacific;
                default:
                    return RiotShards.Unknown;
            }
        }
    }
}
