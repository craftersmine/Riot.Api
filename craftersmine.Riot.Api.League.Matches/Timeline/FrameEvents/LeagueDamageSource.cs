using System;
using System.Collections.Generic;
using System.Text;
using craftersmine.Riot.Api.League.Matches.Converters.FrameEvents;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends damage source
    /// </summary>
    public class LeagueDamageSource
    {
        /// <summary>
        /// Gets an amount of magic damage dealt from this source
        /// </summary>
        [JsonProperty("magicDamage")]
        public int MagicDamage { get; private set; }
        /// <summary>
        /// Gets a participant ID in this match who was damage source
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; private set; }
        /// <summary>
        /// Gets an amount of physical damage dealt from this source
        /// </summary>
        [JsonProperty("physicalDamage")]
        public int PhysicalDamage { get; private set; }
        /// <summary>
        /// Gets a champion spell slot of participant from this source
        /// </summary>
        [JsonProperty("spellSlot")]
        public int SpellSlot { get; private set; }
        /// <summary>
        /// Gets an amount of true damage dealt from this source
        /// </summary>
        [JsonProperty("trueDamage")]
        public int TrueDamage { get; private set; }
        /// <summary>
        /// Gets <see langword="true"/> if it is basic damage (like auto attack)
        /// </summary>
        [JsonProperty("basic")]
        public bool IsBasic { get; private set; }
        /// <summary>
        /// Gets a champion name of participant who was damage source
        /// </summary>
        [JsonProperty("championName")]
        public string ChampionName { get; private set; }
        /// <summary>
        /// Gets a champion spell name which was damage source
        /// </summary>
        [JsonProperty("spellName")]
        public string SpellName { get; private set; }
        /// <summary>
        /// Gets a type of this damage source
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(LeagueDamageTypeConverter))]
        public LeagueDamageType Type { get; private set; }
    }
}
