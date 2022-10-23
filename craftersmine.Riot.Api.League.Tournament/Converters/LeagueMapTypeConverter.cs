using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament.Converters
{
    internal class LeagueMapTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueMapType mapType)
                writer.WriteValue(mapType.GetStringFor());

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueMapTypeFromString();

            throw new JsonReaderException($"Unexpected token for map type: {reader.TokenType}, expected: string");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueMapType);
        }
    }
}
