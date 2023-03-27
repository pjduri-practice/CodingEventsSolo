using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<Event> Events = new List<Event>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;
            return View();
        }

        // GET: /<controller>/add
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        // POST: /<controller>/add
        [HttpPost("events/add")]
        public IActionResult NewEvent(string name, string description) 
        {
            Events.Add(new Event(name, description));

            return Redirect("/events");
        }
    }
}
