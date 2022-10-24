using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament.Converters
{
    internal class LeagueSpectatorTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueSpectatorType spectatorType)
            {
                writer.WriteValue(spectatorType.GetStringFor());
                return;
            }

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueSpectatorTypeFromString();

            throw new JsonReaderException($"Unexpected token for spectator type: {reader.TokenType}, expected: string");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueSpectatorType);
        }
    }
}
