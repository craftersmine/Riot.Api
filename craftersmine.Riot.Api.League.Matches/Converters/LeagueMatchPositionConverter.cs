using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueMatchPositionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueMatchPosition position)
            {
                writer.WriteValue(position.GetLeagueMatchPositionString());
            }

            writer.WriteValue(LeagueMatchPosition.None);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType is JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetLeagueMatchPositionFromString();
                return LeagueMatchPosition.None;
            }

            return LeagueMatchPosition.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueMatchPosition);
        }
    }
}
