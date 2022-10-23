using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common.Converters
{
    internal class RiotPlatformAsLeagueRegionConverter : JsonConverter
    {
        private bool _useFullRegions = false;

        public RiotPlatformAsLeagueRegionConverter()
        {
            _useFullRegions = false;
        }

        public RiotPlatformAsLeagueRegionConverter(bool useFullRegions)
        {
            _useFullRegions = useFullRegions;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotPlatform platform)
            {
                if (!_useFullRegions)
                    writer.WriteValue(platform.GetRiotPlatformString());
                else 
                    writer.WriteValue(platform.GetRiotPlatformFullString());
            }
            
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (!(reader.Value is null))
                {
                    if (!_useFullRegions)
                        return reader.Value.ToString().GetRiotPlatformFromString();
                    return reader.Value.ToString().GetRiotPlatformFromFullString();
                }
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
