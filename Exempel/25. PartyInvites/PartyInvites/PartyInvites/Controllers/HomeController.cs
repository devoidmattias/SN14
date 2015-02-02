
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // skapa  - hantera en modell
            var model = new Salutation();

            // skicka in modellen till vyn
            return View(model);
        }
    }
}