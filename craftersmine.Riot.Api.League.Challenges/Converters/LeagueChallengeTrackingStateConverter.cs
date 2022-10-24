using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges.Converters
{
    internal class LeagueChallengeTrackingStateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueChallengeTrackingState trackingState)
                writer.WriteValue(trackingState.GetStringFor());
            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueChallengeTrackingStateFromString();
            return LeagueChallengeTrackingState.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueChallengeTrackingState);
        }
    }
}
