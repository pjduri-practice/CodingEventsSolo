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
        public IActionResult NewEvent(Event newEvent) 
        {
            EventData.Add(newEvent);

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
            return Redirect("/events");
        }

        public IActionResult Edit()
        {

            return View();
        }

        [HttpPost("events/edit/{eventId}")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {

            return Redirect("/Events");
        }

    }
}
