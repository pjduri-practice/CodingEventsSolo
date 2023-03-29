using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;
using CodingEvents.Data;
using Microsoft.Extensions.Logging;
using CodingEvents.ViewModels;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());
            return View(events);
        }

        // GET: /<controller>/add
        [HttpGet]
        public IActionResult Add() 
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        // POST: /<controller>/add
        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel) 
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Location = addEventViewModel.Location,
                    EstAttendance = addEventViewModel.EstAttendance
                };
                EventData.Add(newEvent);
                return Redirect("/events");
            }
            return View(addEventViewModel);
        }

        // GET: /<controller>/delete
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        // POST: /<controller>
        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int id in eventIds)
            {
                EventData.Remove(id);
            }
            return Redirect("/events");
        }

        // GET: /events/edit/{eventId}
        [HttpGet(("events/edit/{eventId}"))]
        public IActionResult Edit(int eventId)
        {
            Event editEvent = EventData.GetById(eventId);
            ViewBag.editEvent = editEvent;
            ViewBag.editTitle = $"Edit Event {editEvent.Name} (id={editEvent.Id})";

            return View();
        }

        // POST: /events/edit
        [HttpPost("events/edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description, string contactEmail, string location, int estAttendance)
        {
            Event editEvent = EventData.GetById(eventId);
            editEvent.Name = name;
            editEvent.Description = description;
            editEvent.ContactEmail = contactEmail;
            editEvent.Location = location;
            editEvent.EstAttendance = estAttendance;

            return Redirect("/Events");
        }

    }
}
