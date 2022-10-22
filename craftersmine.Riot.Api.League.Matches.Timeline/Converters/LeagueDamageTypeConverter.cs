using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class LeagueDamageTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueDamageType damageType)
            {
                writer.WriteValue(damageType.GetStringFor());
            }

            throw new ArgumentException("Unknown value is specified for damage type", nameof(value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) reader.Value.ToString().GetLeagueDamageTypeFromString();
            }

            return LeagueDamageType.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueDamageType);
        }
    }
}
