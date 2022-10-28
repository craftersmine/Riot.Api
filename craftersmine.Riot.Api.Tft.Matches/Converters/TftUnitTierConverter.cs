using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches.Converters
{
    internal class TftUnitTierConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is TftUnitTier unitTier)
            {
                writer.WriteValue((int)unitTier);
                return;
            }

            writer.WriteValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
                if (reader.Value != null)
                    return (TftUnitTier) ((long) reader.Value);

            return TftUnitTier.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TftUnitTier);
        }
    }
}
