using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // retrive single event
        public static Event GetByID(int id)
        {
            return Events[id];
        }

        // retrive multiple events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // remove an event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}
