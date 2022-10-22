using System;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class LeagueTimelineFrameEventTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueTimelineFrameEventType eventType)
            {
                writer.WriteValue(eventType.GetStringForEventType());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetLeagueTimelineFrameEventTypeFromString();
            }

            return LeagueTimelineFrameEventType.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueTimelineFrameEventType);
        }
    }
}
