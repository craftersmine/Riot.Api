using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueMultikillConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueMultikill multikill)
            {
                writer.WriteValue((int)multikill);
            }

            writer.WriteValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType is JsonToken.Integer)
            {
                if (reader.Value != null) return (LeagueMultikill) Convert.ToInt32(reader.Value);
                return LeagueMultikill.None;
            }

            return LeagueMultikill.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueMultikill);
        }
    }
}
