using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Status.Converters
{
    internal class RiotServiceIncidentSeverityConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RiotServiceIncidentSeverity incidentSeverity)
                writer.WriteValue(incidentSeverity);

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetRiotServiceIncidentSeverityFromString();
            return RiotServiceIncidentSeverity.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RiotServiceIncidentSeverity);
        }
    }
}
