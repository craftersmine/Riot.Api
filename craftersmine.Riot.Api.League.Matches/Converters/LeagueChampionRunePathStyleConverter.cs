using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Converters
{
    internal class LeagueChampionRunePathStyleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueChampionRunePathStyle runePathStyle)
            {
                writer.WriteValue(runePathStyle.GetChampionRunePathStyleString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetChampionRunePathStyleFromString();
            }

            throw new ArgumentException("Unknown rune path style detected! " + reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueChampionRunePathStyle);
        }
    }
}
