using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Client.Replay.Converters
{
    public class AvContainerConverter : JsonConverter
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is LeagueReplayAVContainer container)
                writer.WriteValue(container.GetReplayAvContainerString());

            else
                throw new ArgumentException("Invalid value of type " + value.GetType().FullName +
                                            " to convert to AVContainer");
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                if (reader.Value != null) return reader.Value.ToString().GetReplayAvContainerFromString();
            }

            throw new JsonReaderException("Invalid type of property " + reader.Path + ", expected: " +
                                          JsonToken.String.ToString());
        }

        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LeagueReplayAVContainer);
        }
    }
}
