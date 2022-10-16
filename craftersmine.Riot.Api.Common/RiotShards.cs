using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common.Exceptions;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a Riot Active Shard value
    /// </summary>
    public enum RiotShards
    {
        /// <summary>
        /// Unknown data shard
        /// </summary>
        Unknown,
        /// <summary>
        /// Legends of Runeterra Europe shard
        /// </summary>
        LoREurope,
        /// <summary>
        /// Legends of Runeterra Americas shard
        /// </summary>
        LoRAmericas,
        /// <summary>
        /// Legends of Runeterra Asia and Pacific shard
        /// </summary>
        LoRAsiaPacific,
        /// <summary>
        /// Valorant Europe shard
        /// </summary>
        ValorantEurope,
        /// <summary>
        /// Valorant North America shard
        /// </summary>
        ValorantNorthAmerica,
        /// <summary>
        /// Valorant Latin America shard
        /// </summary>
        ValorantLatinAmerica,
        /// <summary>
        /// Valorant Korea shard
        /// </summary>
        ValorantKorea,
        /// <summary>
        /// Valorant Brazil shard
        /// </summary>
        ValorantBrazil,
        /// <summary>
        /// Valorant Asia and Pacific shard
        /// </summary>
        ValorantAsiaPacific
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="RiotShards"/> enum extensions
    /// </summary>
    public static class RiotShardsExtensions
    {
        /// <summary>
        /// Gets a representing string for <see cref="RiotShards"/> value
        /// </summary>
        /// <param name="shard"><see cref="RiotShards"/> value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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
