using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.SummonerLeagues.Converters
{
    internal class LeagueQueueTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is LeagueQueueType)
            {
                switch ((LeagueQueueType) value)
                {
                    case LeagueQueueType.RankedSoloDuo:
                        writer.WriteValue(LeagueQueueType.RankedSoloDuo.GetLeagueQueueStringFor());
                        break;
                    case LeagueQueueType.RankedFlex:
                        writer.WriteValue(LeagueQueueType.RankedFlex.GetLeagueQueueStringFor());
                        break;
                    default:
                        throw new ArgumentException("Unknown queue type selected!", nameof(value));
                }
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                switch (reader.Value)
                {
                    case LeagueQueueTypeExtensions.RankedSoloDuoQueueId:
                        return LeagueQueueType.RankedSoloDuo;
                    case LeagueQueueTypeExtensions.RankedFlexQueueId:
                        return LeagueQueueType.RankedFlex;
                    default:
                        return LeagueQueueType.Unknown;
                }
            }

            return LeagueQueueType.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
