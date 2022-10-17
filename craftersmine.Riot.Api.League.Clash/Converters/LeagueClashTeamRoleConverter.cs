using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash.Converters
{
    internal class LeagueClashTeamRoleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueClashTeamRole teamRole)
            {
                if (teamRole != LeagueClashTeamRole.Unknown)
                    writer.WriteValue(teamRole.GetLeagueClashTeamRoleString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (!(reader.Value is null)) return reader.Value.ToString().GetLeagueClashTeamRoleFromString();
            }

            return LeagueClashTeamRole.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
