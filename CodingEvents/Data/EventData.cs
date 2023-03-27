using CodingEvents.Models;
namespace CodingEvents.Data
{
    public class EventData
    {
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // fetch all events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // add a new event to dictionary
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // remove event from dictionary
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        // fetch a specific event
        public static Event GetById(int id)
        {
            return Events[id];
        }

    }
}
