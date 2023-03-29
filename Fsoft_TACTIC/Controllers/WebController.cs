using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsoft_TACTIC.Controllers
{
    public class WebController : Controller
    {
        // GET: Web
        public ActionResult JobListing()
        {
            return View();
        }
    }
}