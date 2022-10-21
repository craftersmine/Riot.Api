using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a collection of League of Legends match timeline frame events
    /// </summary>
    public class LeagueMatchTimelineFrameEventCollection : List<ILeagueTimelineFrameEvent>
    {
        /// <summary>
        /// Gets an array of events of specified type
        /// </summary>
        /// <typeparam name="T">Type of events to fetch</typeparam>
        /// <returns>An array of events with type of <see cref="T"/></returns>
        public T[] GetEventsOfType<T>() where T : ILeagueTimelineFrameEvent
        {
            List<T> evts = new List<T>();
            foreach (ILeagueTimelineFrameEvent evt in this)
            {
                if (evt is T evtT)
                {
                    evts.Add(evtT);
                }
            }
            
            return evts.ToArray();
        }
    }
}
