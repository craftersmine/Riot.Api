﻿using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class LeagueTowerTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueTowerType towerType)
                writer.WriteValue(towerType.GetStringFor());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueTowerTypeFromString();
            return LeagueTowerType.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueTowerType);
        }
    }
}
