using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common.Converters
{
    internal class RiotShardGameConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotShardGame)
            {
                switch ((RiotShardGame) value)
                {
                    case RiotShardGame.LegendsOfRuneterra:
                        writer.WriteValue(Constants.ShardGameLegendsOfRunterra);
                        break;
                    case RiotShardGame.Valorant:
                        writer.WriteValue(Constants.ShardGameValorant);
                        break;
                    default:
                        throw new ArgumentException("Unknown shard game selected!", nameof(value));
                }
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                switch (reader.Value)
                {
                    case Constants.ShardGameLegendsOfRunterra:
                        return RiotShardGame.LegendsOfRuneterra;
                    case Constants.ShardGameValorant:
                        return RiotShardGame.Valorant;
                }
            }
            
            return RiotShardGame.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
