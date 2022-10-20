﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using craftersmine.Riot.Api.League.Matches.Converters;
using craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnixDateTimeConverter = craftersmine.Riot.Api.Common.Converters.UnixDateTimeConverter;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline frame
    /// </summary>
    public class LeagueMatchTimelineFrame
    {
        [JsonProperty("events")]
        private JObject[] EventsRaw { get; set; }

        /// <summary>
        /// Gets an array of League of Legends match timeline current frame events
        /// </summary>
        public ILeagueTimelineFrameEvent[] Events => GetFromRawEvents();
        /// <summary>
        /// Gets an array of League of Legends match timeline current participant frames
        /// </summary>
        [JsonProperty("participantFrames")]
        public LeagueMatchTimelineParticipantFrameCollection ParticipantFrames { get; private set; }
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> timestamp of frame from the game beginning
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixTimeSpanConverter), true)]
        public TimeSpan Timestamp { get; private set; }

        private ILeagueTimelineFrameEvent[] GetFromRawEvents()
        {
            List<ILeagueTimelineFrameEvent> _events = new List<ILeagueTimelineFrameEvent>();
            foreach (var e in EventsRaw)
            {
                BaseTimelineFrameEvent evt = DeserializeJObjectTo<BaseTimelineFrameEvent>(e);
                switch (evt.Type)
                {
                    case LeagueTimelineFrameEventType.PauseEnd:
                        _events.Add(DeserializeJObjectTo<PauseEndTimelineFrameEvent>(e));
                        break;
                    case LeagueTimelineFrameEventType.SkillLevelUp:
                        _events.Add(DeserializeJObjectTo<SkillLevelUpFrameEvent>(e));
                        break;
                    case LeagueTimelineFrameEventType.ItemPurchased:
                    case LeagueTimelineFrameEventType.ItemDestroyed:
                    case LeagueTimelineFrameEventType.ItemSold:
                        _events.Add(DeserializeJObjectTo<ItemFrameEvent>(e));
                        break;
                    case LeagueTimelineFrameEventType.ItemUndo:
                        _events.Add(DeserializeJObjectTo<ItemUndoFrameEvent>(e));
                        break;
                    case LeagueTimelineFrameEventType.WardKill:
                        _events.Add(DeserializeJObjectTo<WardKilledFrameEvent>(e));
                        break;
                    case LeagueTimelineFrameEventType.WardPlaced:
                        _events.Add(DeserializeJObjectTo<WardPlacedFrameEvent>(e));
                        break;
                    default:
                        _events.Add(evt);
                        break;
                }
            }

            return _events.ToArray();
        }

        private T DeserializeJObjectTo<T>(JObject jObject)
        {
            return JsonConvert.DeserializeObject<T>(jObject.ToString());
        }
    }
}
