using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace craftersmine.Riot.Api.Status.Converters
{
    internal class RiotServicePlatformConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotServicePlatform servicePlatform)
                writer.WriteValue(servicePlatform.GetStringFor());

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetRiotServicePlatformFromString();

            throw new JsonReaderException($"Unable to convert value {reader.Value} to {nameof(RiotServicePlatform)}");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RiotServicePlatform);
        }
    }
}
