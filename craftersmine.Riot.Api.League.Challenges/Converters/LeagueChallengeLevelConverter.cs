using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges.Converters
{
    internal class LeagueChallengeLevelConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueChallengeLevel challengeLevel)
            {
                writer.WriteValue(challengeLevel.GetStringFor());
                return;
            }

            writer.WriteValue(LeagueChallengeLevel.None);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
                if (reader.Value != null)
                    return reader.Value.ToString().GetLeagueChallengeLevelFromString();
            return LeagueChallengeLevel.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueChallengeLevel);
        }
    }
}
