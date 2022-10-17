using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.SummonerLeagues.Converters
{
    internal class LeagueRankedTierConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueRankedTier)
            {
                switch ((LeagueRankedTier) value)
                {
                    case LeagueRankedTier.Iron:
                        writer.WriteValue(LeagueRankedTier.Iron.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Bronze:
                        writer.WriteValue(LeagueRankedTier.Bronze.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Silver:
                        writer.WriteValue(LeagueRankedTier.Silver.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Gold:
                        writer.WriteValue(LeagueRankedTier.Gold.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Platinum:
                        writer.WriteValue(LeagueRankedTier.Platinum.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Diamond:
                        writer.WriteValue(LeagueRankedTier.Diamond.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Master:
                        writer.WriteValue(LeagueRankedTier.Master.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Grandmaster:
                        writer.WriteValue(LeagueRankedTier.Grandmaster.GetRankedTierString());
                        break;
                    case LeagueRankedTier.Challenger:
                        writer.WriteValue(LeagueRankedTier.Challenger.GetRankedTierString());
                        break;
                    default:
                        throw new ArgumentException("Unknown League of Legends ranked tier selected!", nameof(value));
                }
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return reader.Value?.ToString()?.GetLeagueRankedTierFromString();
            }

            return LeagueRankedTier.Unknown;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
