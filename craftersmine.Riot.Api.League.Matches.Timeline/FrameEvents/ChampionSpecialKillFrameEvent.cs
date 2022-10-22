using craftersmine.Riot.Api.League.Matches.Converters;
using craftersmine.Riot.Api.League.Matches.Timeline.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends special killing event (first blood, ace, multi kill, etc.)
    /// </summary>
    public class ChampionSpecialKillFrameEvent : BaseTimelineFrameEvent
    {
        /// <summary>
        /// Gets a participant ID in this match who caused this event
        /// </summary>
        [JsonProperty("killerId")]
        public int KillerId { get; private set; }
        /// <summary>
        /// Gets a total length of multi kill made by participant if it is multi kill
        /// </summary>
        [JsonProperty("multiKillLength"), JsonConverter(typeof(LeagueMultikillConverter))]
        public LeagueMultikill MultiKillLength { get; private set; }
        /// <summary>
        /// Gets a position in the League of Legends world where this event is occurred
        /// </summary>
        [JsonProperty("position")]
        public LeagueWorldPosition Position { get; private set; }
        /// <summary>
        /// Gets a type of special kill
        /// </summary>
        [JsonProperty("killType"), JsonConverter(typeof(LeagueSpecialKillTypeConverter))]
        public LeagueSpecialKillType KillType { get; private set; }
    }
}
