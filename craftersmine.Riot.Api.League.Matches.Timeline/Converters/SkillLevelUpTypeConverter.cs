using System;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.Converters
{
    internal class SkillLevelUpTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is SkillLevelUpType levelUpType)
            {
                writer.WriteValue(levelUpType.GetStringFor());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetSkillLevelUpTypeFromString();
            }

            return SkillLevelUpType.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SkillLevelUpType);
        }
    }
}
