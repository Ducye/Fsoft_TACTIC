using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Fsoft_TACTIC.Controllers
{
    public class WebController : Controller
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Rg63IvGlW1TDX5tsHxyTIBcy8GbnBd2zfX8xYAPr",
            BasePath = "https://tactic-8da8d-default-rtdb.asia-southeast1.firebasedatabase.app\r\n\r\n"
        };
        // GET: Web
        public ActionResult JobListing()
        {
            return View();
        }
    }
}