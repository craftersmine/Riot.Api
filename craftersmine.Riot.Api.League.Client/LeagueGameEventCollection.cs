using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    internal class LeagueGameEventCollection : List<JObject>
    {
        public ILeagueGameEvent GetEvent(int id)
        {
            JObject evt = this.First(o => o.Value<int>("EventID") == id);
            LeagueBaseGameEvent evt1 = evt.ToObject<LeagueBaseGameEvent>();
            switch (evt1.EventType)
            {
                case LeagueGameEventType.GameStart:
                    return evt.ToObject<GameStartEvent>();
                case LeagueGameEventType.MinionsSpawning:
                    return evt.ToObject<MinionsSpawningEvent>();
                case LeagueGameEventType.ChampionKill:
                    return evt.ToObject<ChampionKillEvent>();
                case LeagueGameEventType.FirstBlood:
                    return evt.ToObject<FirstBloodEvent>();
                case LeagueGameEventType.Multikill:
                    return evt.ToObject<MultiKillEvent>();
                case LeagueGameEventType.TurretKilled:
                    return evt.ToObject<TurretDestroyedEvent>();
                case LeagueGameEventType.FirstBrick:
                    return evt.ToObject<FirstBrickEvent>();
                case LeagueGameEventType.InhibKilled:
                    return evt.ToObject<InhibitorDestroyedEvent>();
                case LeagueGameEventType.Ace:
                    return evt.ToObject<AceEvent>();
                case LeagueGameEventType.GameEnd:
                    return evt.ToObject<GameEndEvent>();
                default:
                    return evt1;
            }
        }

        public ILeagueGameEvent[] GetEvents()
        {
            List<ILeagueGameEvent> events = new List<ILeagueGameEvent>();
            foreach (var evt in this)
            {
                events.Add(GetEvent(evt.Value<int>("EventID")));
            }

            return events.ToArray();
        }
    }
}
