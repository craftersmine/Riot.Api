using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Tft.Matches.Converters
{
    internal class TftTraitStyleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is TftTraitStyle traitStyle)
            {
                writer.WriteValue((int)traitStyle);
                return;
            }

            writer.WriteValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
                if (reader.Value != null)
                    return (TftTraitStyle)((long)reader.Value);
            throw new JsonReaderException("Unexpected token " + reader.TokenType + ", expected " + JsonToken.Integer);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TftTraitStyle);
        }
    }
}
