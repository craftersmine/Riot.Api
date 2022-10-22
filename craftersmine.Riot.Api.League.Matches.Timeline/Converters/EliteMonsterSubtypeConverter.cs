using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class EliteMonsterSubtypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is EliteMonsterSubtype eliteMonsterSubtype)
                writer.WriteValue(eliteMonsterSubtype.GetStringFor());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetEliteMonsterSubtypeFromString();

            return EliteMonsterSubtype.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(EliteMonsterSubtype);
        }
    }
}
