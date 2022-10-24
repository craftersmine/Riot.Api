using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches
{
    /// <summary>
    /// Represents a League of Legends match information
    /// </summary>
    public class LeagueMatchInfo
    {
        /// <summary>
        /// Gets a League of Legends Map ID
        /// </summary>
        [JsonProperty("mapId")]
        public int MapId { get; private set; }
        /// <summary>
        /// Gets a League of Legends Queue Type ID
        /// </summary>
        [JsonProperty("queueId")]
        public int QueueId { get; private set; }
        /// <summary>
        /// Gets a League of Legends match game ID
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; private set; }

        /// <summary>
        /// Gets a League of Legends Game Mode ID
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; private set; }
        /// <summary>
        /// Gets a League of Legends match game name
        /// </summary>
        [JsonProperty("gameName")]
        public string GameName { get; private set; }
        /// <summary>
        /// Gets a League of Legends game type
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; private set; }
        /// <summary>
        /// Gets a League of Legends Tournament ID
        /// </summary>
        [JsonProperty("tournamentId")]
        public string TournamentId { get; private set; }

        /// <summary>
        /// Gets a League of Legends server region where game was played
        /// </summary>
        [JsonProperty("platformId"), JsonConverter(typeof(RiotPlatformAsLeagueRegionConverter))]
        public RiotPlatform GameRegion { get; private set; } 

        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when game was created on League of Legends servers
        /// </summary>
        [JsonProperty("gameCreation"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime GameCreationTimestamp { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when game was started on League of Legends servers (usually after loading screen)
        /// </summary>
        [JsonProperty("gameStartTimestamp"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime GameStartTimestamp { get; private set; }
        /// <summary>
        /// Gets a <see cref="DateTime"/> timestamp when game was ended on League of Legends servers
        /// </summary>
        /// <remarks>
        ///  This timestamp can occasionally be longer than when the match is actually "ends". <br/>
        ///  The most reliable way of determining the timestamp for the end of the match would be to add the max <br/>
        ///  time played on any participant to the <see cref="GameStartTimestamp"/>
        /// </remarks>
        // TODO: Add extension method to calculate this automatically
        [JsonProperty("gameEndTimestamp"), JsonConverter(typeof(UnixDateTimeConverter), false)]
        public DateTime GameEndTimestamp { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> of the game duration
        /// </summary>
        [JsonProperty("gameDuration"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan GameDuration { get; private set; }

        /// <summary>
        /// Gets a League of Legends full version on which game was played
        /// </summary>
        [JsonProperty("gameVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version GameVersion { get; private set; }
        /// <summary>
        /// Gets an array of League of Legends participants in this game
        /// </summary>
        [JsonProperty("participants")]
        public LeagueMatchParticipant[] Participants { get; private set; }
        /// <summary>
        /// Gets an array of League of Legends teams in this game
        /// </summary>
        [JsonProperty("teams")]
        public LeagueMatchTeam[] Teams { get; private set; }
    }
}
