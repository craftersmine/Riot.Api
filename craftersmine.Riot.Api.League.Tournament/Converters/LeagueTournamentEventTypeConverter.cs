using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Tournament.Converters
{
    internal class LeagueTournamentEventTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueTournamentEventType tournamentEventType)
            {
                writer.WriteValue(tournamentEventType.GetStringFor());
                return;
            }

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueTournamentEventTypeFromString();
            throw new JsonReaderException($"Unexpected token {reader.TokenType.ToString()}, expected string");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueTournamentEventType);
        }
    }
}
