﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private Dictionary<string,string > Events = new Dictionary<string, string>();

        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
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
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(name, description);
            return Redirect("/Events");
        }
    }
}
