using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match participant from match timeline
    /// </summary>
    public class LeagueMatchTimelineParticipant
    {
        /// <summary>
        /// Gets a participant ID in this game (index that starts from 1 that corresponds to participant in <see cref="craftersmine.Riot.Api.League.Matches.Timeline.LeagueMatchTimelineInfo.Participants"/> array)
        /// </summary>
        [JsonProperty("participantId")]
        public int Id { get; private set; }
        /// <inheritdoc cref="craftersmine.Riot.Api.League.Matches.LeagueMatchParticipant.Puuid"/>
        [JsonProperty("puuid")]
        public string Puuid { get; private set; }
    }
}
