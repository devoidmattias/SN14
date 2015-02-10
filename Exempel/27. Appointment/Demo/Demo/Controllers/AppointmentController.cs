using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Appointment appointment)
        {

            if (ModelState.IsValid)
            {
                return View("ViewAppointment", appointment);
            }

            return View();

        }

        public JsonResult ValidateName(string clientName)
        {
            if (String.IsNullOrEmpty(clientName))
            {
                return Json("Ange ett namn", JsonRequestBehavior.AllowGet);
            }
           else if (clientName == "Mattias")
            {
                return Json("Namnet är upptaget", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);

            }

        }
    }
}