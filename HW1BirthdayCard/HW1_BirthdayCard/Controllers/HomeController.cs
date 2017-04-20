using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1_BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendForm(Models.CardEntry cardEntry)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", cardEntry);
            }
            else
            {
                return View();
            }
        }
    }
}