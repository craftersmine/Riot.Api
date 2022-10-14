using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public enum RiotShardGame
    {
        Unknown,
        LegendsOfRunterra,
        Valorant
    }

    public static class RiotShardGameExtensions
    {
        public static string GetShardGameString(this RiotShardGame game)
        {
            switch (game)
            {
                case RiotShardGame.LegendsOfRunterra:
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
