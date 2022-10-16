using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Represents a Riot Game Data Shard
    /// </summary>
    public enum RiotShardGame
    {
        /// <summary>
        /// Unknown game data shard
        /// </summary>
        Unknown,
        LegendsOfRunterra,
        /// Data shard for League of Runeterra (LoR)
        /// </summary>
        LegendsOfRuneterra,
        /// <summary>
        /// Data shard for Valorant
        /// </summary>
        Valorant
    }
    
    /// <summary>
    /// Contains a static methods for <see cref="RiotShardGame"/> enum extensions
    /// </summary>
    public static class RiotShardGameExtensions
    {
        /// <summary>
        /// Gets a representing string for <see cref="RiotShardGame"/> value
        /// </summary>
        /// <param name="game"><see cref="RiotShardGame"/> value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetShardGameString(this RiotShardGame game)
        {
            switch (game)
            {
                case RiotShardGame.LegendsOfRuneterra:
                    return Constants.ShardGameLegendsOfRunterra;
                case RiotShardGame.Valorant:
                    return Constants.ShardGameValorant;
                default:
                    throw new ArgumentException("Unknown game for active shard selected!", nameof(game));
            }
        }

        internal static RiotShardGame GetShardGameFromString(this string str)
        {
            switch (str.ToLower())
            {
                case Constants.ShardGameLegendsOfRunterra:
                    return RiotShardGame.LegendsOfRunterra;
                case Constants.ShardGameValorant:
                    return RiotShardGame.Valorant;
                default:
                    return RiotShardGame.Unknown;
            }
        }
    }
}
