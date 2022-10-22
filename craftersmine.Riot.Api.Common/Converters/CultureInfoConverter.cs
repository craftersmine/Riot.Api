using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Common.Converters
{
    internal class CultureInfoConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is CultureInfo cultureInfo)
                writer.WriteValue(cultureInfo.Name.Replace('-', '_'));

            throw new ArgumentException($"Unable to convert type \"{value.GetType().Name}\", expected " +
                                        nameof(CultureInfo));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return new CultureInfo(reader.Value.ToString().Replace('_', '-'));

            return CultureInfo.InvariantCulture;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(CultureInfo);
        }
    }
}
