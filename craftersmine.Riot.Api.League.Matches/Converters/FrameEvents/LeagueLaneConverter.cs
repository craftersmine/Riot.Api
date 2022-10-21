using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters.FrameEvents
{
    internal class LeagueLaneConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueLane lane)
                writer.WriteValue(lane.GetStringFor());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    reader.Value.ToString().GetLeagueLaneFromString();
            throw new JsonReaderException("Unable to convert value to LeagueLane: " + reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueLane);
        }
    }
}
