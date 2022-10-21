using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;

using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters.FrameEvents
{
    internal class LeagueBuildingTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueBuildingType buildingType)
                writer.WriteValue(buildingType.GetStringFor());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueBuildingTypeFromString();
            throw new JsonReaderException("Unable to convert value to LeagueLane: " + reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueBuildingType);
        }
    }
}
