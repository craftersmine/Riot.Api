using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Clash.Converters
{
    internal class LeagueClashTeamTierConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueClashTeamTier)
            {
                writer.WriteValue((int)value);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer && !(reader.Value is null))
            {
                switch ((int)reader.Value)
                {
                    case 1:
                        return LeagueClashTeamTier.TierI;
                    case 2:
                        return LeagueClashTeamTier.TierII;
                    case 3:
                        return LeagueClashTeamTier.TierIII;
                    case 4:
                        return LeagueClashTeamTier.TierIV;
                    default:
                        return LeagueClashTeamTier.Unknown;
                }
            }

            return LeagueClashTeamTier.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
