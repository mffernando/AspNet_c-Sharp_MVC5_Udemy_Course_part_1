﻿using Intro.Models;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //new person
            var person = new Person
            {
                PersonId = 1,
                Name = "Name",
                Type = "Admin"
            };

            //Example ViewData[ ]
            ViewData["PersonId"] = person.PersonId;
            ViewData["Name"] = person.Name;
            ViewData["Type"] = person.Type;

            //Example ViewBag
            ViewBag.id = person.PersonId;
            ViewBag.name = person.Name;
            ViewBag.type = person.Type;

            return View(); // return > Views > Home > Index.chstml
        }

        //new view Contacts (Views > Home > Contacts)
        public ActionResult Contacts()
        {
            return View(); // return > Views > Home > Contacts.cshtml
        }
    }
}