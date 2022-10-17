using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common.Converters
{
    internal class RiotShardConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotShards)
            {
                switch ((RiotShards) value)
                {
                    case RiotShards.LoREurope:
                        writer.WriteValue(Constants.ShardLoREurope);
                        break;
                    case RiotShards.LoRAmericas:
                        writer.WriteValue(Constants.ShardLoRAmericas);
                        break;
                    case RiotShards.LoRAsiaPacific:
                        writer.WriteValue(Constants.ShardLoRAsiaPacific);
                        break;
                    case RiotShards.ValorantEurope:
                        writer.WriteValue(Constants.ShardValorantEurope);
                        break;
                    case RiotShards.ValorantNorthAmerica:
                        writer.WriteValue(Constants.ShardValorantNorthAmerica);
                        break;
                    case RiotShards.ValorantLatinAmerica:
                        writer.WriteValue(Constants.ShardValorantLatinAmerica);
                        break;
                    case RiotShards.ValorantAsiaPacific:
                        writer.WriteValue(Constants.ShardValorantAsiaPacific);
                        break;
                    case RiotShards.ValorantBrazil:
                        writer.WriteValue(Constants.ShardValorantBrazil);
                        break;
                    case RiotShards.ValorantKorea:
                        writer.WriteValue(Constants.ShardValorantKorea);
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
                    case Constants.ShardValorantAsiaPacific:
                        return RiotShards.ValorantAsiaPacific;
                    case Constants.ShardValorantBrazil:
                        return RiotShards.ValorantBrazil;
                    case Constants.ShardValorantKorea:
                        return RiotShards.ValorantKorea;
                    default:
                        return RiotShards.Unknown;
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
