using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Leagues.Converters
{
    internal class TftHyperRollTierConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is TftHyperRollTier hyperRollTier)
                writer.WriteValue(hyperRollTier.GetStringFor());

            throw new ArgumentException("Unknown value passed to convert! " + value.GetType());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetTftHyperRollTierFromString();

            throw new JsonReaderException("Unexpected token " + reader.TokenType.ToString() + ", expected: " +
                                          JsonToken.String.ToString());
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TftHyperRollTier);
        }
    }
}
