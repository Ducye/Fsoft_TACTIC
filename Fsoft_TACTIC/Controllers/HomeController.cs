using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsoft_TACTIC.Controllers
{
    public class HomeController : Controller
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Rg63IvGlW1TDX5tsHxyTIBcy8GbnBd2zfX8xYAPr",
            BasePath = "https://tactic-8da8d-default-rtdb.asia-southeast1.firebasedatabase.app\r\n\r\n"
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}