﻿namespace CodingEvents.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ContactEmail { get; set; }
        public string? Location { get; set; }
        public int? EstAttendance { get; set; }

        public Event()
        {
        }

        public Event(string name, string description, string contactEmail, string location, int estAttendance): this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Location = location;
            EstAttendance = estAttendance;
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
