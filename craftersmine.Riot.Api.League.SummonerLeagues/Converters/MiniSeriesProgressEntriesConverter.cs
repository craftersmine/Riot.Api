using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.SummonerLeagues.Converters
{
    internal class MiniSeriesProgressEntriesConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is MiniSeriesProgressEntry[] entries)
            {
                string str = string.Empty;
                foreach (var entry in entries)
                {
                    switch (entry)
                    {
                        case MiniSeriesProgressEntry.Won:
                            str += "W";
                            break;
                        case MiniSeriesProgressEntry.Lost:
                            str += "L";
                            break;
                        case MiniSeriesProgressEntry.NotPlayed:
                            str += "N";
                            break;
                    }
                }
            }
            else
                throw new ArgumentException(
                    "Invalid parameter passed in! Expected MiniSeriesProgressEntry[], got " + value?.GetType(),
                    nameof(value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                List<MiniSeriesProgressEntry> entries = new List<MiniSeriesProgressEntry>();
                if (reader.Value != null)
                    foreach (var entry in reader.Value.ToString())
                    {
                        switch (entry)
                        {
                            case 'W':
                                entries.Add(MiniSeriesProgressEntry.Won);
                                break;
                            case 'L':
                                entries.Add(MiniSeriesProgressEntry.Lost);
                                break;
                            case 'N':
                                entries.Add(MiniSeriesProgressEntry.NotPlayed);
                                break;
                        }
                    }

                return entries.ToArray();
            }
            
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
