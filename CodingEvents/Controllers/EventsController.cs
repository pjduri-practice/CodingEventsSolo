using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<string> Events = new List<string>();

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
        public IActionResult NewEvent(string name) 
        {
            Events.Add(name);
            return Redirect("/events");
        }
    }
}
