using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;
using CodingEvents.Data;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<Event> Events = new List<Event>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();
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
            EventData.Add(new Event(name, description));

            return Redirect("/events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int id in eventIds)
            {
                EventData.Remove(id);
            }
            return Redirect("/Events");
        }

    }
}
