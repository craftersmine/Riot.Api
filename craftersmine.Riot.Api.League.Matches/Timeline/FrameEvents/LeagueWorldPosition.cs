using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a position of event in League of Legends match world
    /// </summary>
    public struct LeagueWorldPosition
    {
        /// <summary>
        /// Gets X position in world
        /// </summary>
        [JsonProperty("x")]
        public int X { get; private set; }
        /// <summary>
        /// Gets Y position in world
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; private set; }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            return $@"{X}, {Y}";
        }
    }
}
