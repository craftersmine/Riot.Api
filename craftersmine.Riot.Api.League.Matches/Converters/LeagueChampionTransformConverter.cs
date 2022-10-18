using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueChampionTransformConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueChampionTransform transform)
            {
                writer.WriteValue((int)transform);
            }

            writer.WriteValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType is JsonToken.Integer)
            {
                if (reader.Value != null) return (LeagueChampionTransform) reader.Value;
                return LeagueChampionTransform.None;
            }

            return LeagueChampionTransform.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueChampionTransform);
        }
    }
}
