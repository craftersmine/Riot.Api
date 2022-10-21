using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueBountyLevelConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueBountyLevel bountyLevel)
            {
                writer.WriteValue((int)bountyLevel);
            }

            writer.WriteValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType is JsonToken.Integer)
            {
                if (reader.Value != null) return (LeagueBountyLevel) (Convert.ToInt32(reader.Value));
                return LeagueBountyLevel.None;
            }

            return LeagueBountyLevel.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueBountyLevel);
        }
    }
}
