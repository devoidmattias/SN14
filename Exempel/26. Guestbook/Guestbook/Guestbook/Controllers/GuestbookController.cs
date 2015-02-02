using Guestbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbook.Controllers
{
    public class GuestbookController : Controller
    {
        private static readonly GuestbookDb _guestBookDb = new GuestbookDb();

      
        
        // GET: Guestbook
        public ActionResult Index()
        {
            var model = _guestBookDb.Messages.ToList();
            return View(model);
        }

        // GET: Guestbook/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guestbook/Create
        [HttpPost]
        public ActionResult Create(Message message)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            message.Created = DateTime.Now;
            _guestBookDb.Add(message);

            return RedirectToAction("Index");
        }
    }
}