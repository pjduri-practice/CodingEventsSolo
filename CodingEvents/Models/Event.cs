﻿namespace CodingEvents.Models
{
    public class Event
    {
        public int Id { get; }
        private static int nextId = 1;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ContactEmail { get; set; }

        public Event()
        {
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description, string contactEmail): this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
