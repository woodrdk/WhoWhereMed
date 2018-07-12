using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhoWhere.Models;

namespace WhoWhere.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(People peep)
        {
            return View();
        }
    }
}