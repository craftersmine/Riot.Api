using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class LeagueSpecialKillTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueSpecialKillType specialKillType)
            {
                writer.WriteValue(specialKillType.GetStringFor());
            }

            throw new ArgumentException("Unknown value is passed as special kill type " + value.GetType().Name, nameof(value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetLeagueSpecialKillTypeFromString();
            }

            throw new JsonReaderException("Unknown token for special kill value " + reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueSpecialKillType);
        }
    }
}
