using System.Collections.Generic;
using System.Linq;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline participant frames collection
    /// </summary>
    public class LeagueMatchTimelineParticipantFrameCollection : Dictionary<string, LeagueMatchTimelineParticipantFrame>
    {
        /// <summary>
        /// Gets a participant frame by participant ID
        /// </summary>
        /// <param name="participantId">Participant ID in this match</param>
        /// <returns></returns>
        public LeagueMatchTimelineParticipantFrame GetParticipantById(int participantId)
        {
            if (this.ContainsKey(participantId.ToString()))
                return this[participantId.ToString()];

            return this.FirstOrDefault(p => p.Value.ParticipantId == participantId).Value;
        }
    }
}
