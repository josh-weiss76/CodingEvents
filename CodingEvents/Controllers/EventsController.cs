using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();

        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //Events.Add("Retirement Ceremony");
            //Events.Add("Last Day of LaunchCode Code Camp");
            //Events.Add("First Day at Microsoft");
            ViewBag.events = Events;
            return View();
        }
        //Adding action method to add a form to update the list of events
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Adding action method to handle form submission
        [HttpPost]
        [Route("/Events/Add")]  
        public IActionResult NewEvent(string name)
        {
            Events.Add(name);
            return Redirect("/Events");
        }
    }
}
