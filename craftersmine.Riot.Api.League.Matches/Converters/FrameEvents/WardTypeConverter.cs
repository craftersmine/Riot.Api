using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters.FrameEvents
{
    internal class WardTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is WardType wardType)
            {
                writer.WriteValue(wardType.GetStringFor());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetWardTypeFromString();
            }

            return WardType.Undefined;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(WardType);
        }
    }
}
