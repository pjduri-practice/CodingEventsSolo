using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static Dictionary<string, string> Events = new Dictionary<string, string>();

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
            Events.Add(name, description);
            return Redirect("/events");
        }
    }
}
