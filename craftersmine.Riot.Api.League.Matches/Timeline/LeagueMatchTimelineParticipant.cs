using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match participant from match timeline
    /// </summary>
    public class LeagueMatchTimelineParticipant
    {
        /// <summary>
        /// Gets a participant ID in this game (index that starts from 1 that corresponds to participant in <see cref="LeagueMatchTimelineInfo.Participants"/> array)
        /// </summary>
        [JsonProperty("participantId")]
        public int Id { get; private set; }
        /// <inheritdoc cref="LeagueMatchParticipant.Puuid"/>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
    }
}
