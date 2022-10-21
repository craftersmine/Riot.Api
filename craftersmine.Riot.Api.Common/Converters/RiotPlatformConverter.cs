using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common.Converters
{
    internal class RiotPlatformAsLeagueRegionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotPlatform platform)
            {
                writer.WriteValue(platform.GetRiotPlatformString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (!(reader.Value is null)) return reader.Value.ToString().GetRiotPlatformFromString();
                throw new ArgumentException("Unknown Riot Platform detected while converting JSON!");
            }
            throw new ArgumentException("Unknown type detected while converting JSON!");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RiotPlatform);
        }
    }
}
