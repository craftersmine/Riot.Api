using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueMatchRoleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueMatchRole role)
            {
                writer.WriteValue(role.GetLeagueMatchRoleString());
            }

            writer.WriteValue(LeagueMatchRole.None);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType is JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetLeagueMatchRoleFromString();
                return LeagueMatchRole.None;
            }

            return LeagueMatchRole.None;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueMatchRole);
        }
    }
}
