﻿using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class EliteMonsterTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is EliteMonsterType eliteMonsterType)
                writer.WriteValue(eliteMonsterType.GetStringFor());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetEliteMonsterTypeFromString();

            throw new JsonReaderException("Unknown value for elite monster type " + reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(EliteMonsterType);
        }
    }
}
