using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.SummonerLeagues.Converters
{
    internal class LeagueDivisionRankConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is LeagueDivisionRank)
            {
                switch ((LeagueDivisionRank) value)
                {
                    case LeagueDivisionRank.I:
                        writer.WriteValue(LeagueDivisionRank.I.GetLeagueDivisionRankString());
                        break;
                    case LeagueDivisionRank.II:
                        writer.WriteValue(LeagueDivisionRank.II.GetLeagueDivisionRankString());
                        break;
                    case LeagueDivisionRank.III:
                        writer.WriteValue(LeagueDivisionRank.III.GetLeagueDivisionRankString());
                        break;
                    case LeagueDivisionRank.IV:
                        writer.WriteValue(LeagueDivisionRank.IV.GetLeagueDivisionRankString());
                        break;
                    default:
                        throw new ArgumentException("Unknown division rank selected!", nameof(value));
                }
            }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return reader.Value?.ToString()?.GetLeagueDivisionFromString();
            }

            return LeagueDivisionRank.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
