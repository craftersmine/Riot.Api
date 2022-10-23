using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges.Converters
{
    internal class LeagueChallengeStateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueChallengeState challengeState)
                writer.WriteValue(challengeState.GetStringFor());

            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueChallengeStateFromString();
            return LeagueChallengeState.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueChallengeState);
        }
    }
}
