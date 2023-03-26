using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class Events : Controller
    {
        List<string> CodeEvents = new List<string>();
        
        public IActionResult Index()
        {
            CodeEvents.Add("Coffee and Code");
            CodeEvents.Add("Code till Dawn");
            CodeEvents.Add("Rocko's Modern Code");
            CodeEvents.Add("Codegaroo Guru Session with Rocko");
            CodeEvents.Add("STL Tech Week");
            CodeEvents.Add("Coding with Aardvarks");
            CodeEvents.Add("Rock and Code");
            CodeEvents.Add("Code and Roll");
            ViewBag.events = CodeEvents;

            return View();
        }

        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost("events/add")]
        public IActionResult NewEvent(string name) 
        {
            CodeEvents.Add(name);
            return Redirect("/events");
        }
    }
}
