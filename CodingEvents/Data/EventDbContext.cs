using Microsoft.EntityFrameworkCore;
using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventDbContext : DbContext
    {
        DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

    }
}
