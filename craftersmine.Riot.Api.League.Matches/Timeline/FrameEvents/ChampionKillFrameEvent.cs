using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends champion kill timeline frame event
    /// </summary>
    public class ChampionKillFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets an array of participants IDs in this match who is participated in kill
        /// </summary>
        [JsonProperty("assistingParticipantIds")]
        public int[] AssistingParticipantIds { get; private set; }
        /// <summary>
        /// Gets a killer bounty value
        /// </summary>
        [JsonProperty("bounty")]
        public int Bounty { get; private set; }
        /// <summary>
        /// Gets a killer current kill streak
        /// </summary>
        [JsonProperty("killStreakLength")]
        public int KillStreak { get; private set; }
        /// <summary>
        /// Gets a killer participant ID in this match
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets a bounty killer got from shutdown
        /// </summary>
        [JsonProperty("shutdownBounty")]
        public int ShutdownBounty { get; private set; }
        /// <summary>
        /// Gets a kill event position in League of Legends world
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
        /// <summary>
        /// Gets an array of <see cref="LeagueDamageSource"/> of victim damage dealt to killer before death
        /// </summary>
        [JsonProperty("victimDamageDealt")]
        public LeagueDamageSource[] VictimDamageDealt { get; private set; }
        /// <summary>
        /// Gets an array of <see cref="LeagueDamageSource"/> of damage dealt to victim by killers
        /// </summary>
        [JsonProperty("victimDamageReceived")]
        public LeagueDamageSource[] VictimDamageReceived { get; private set; }
    }
}
