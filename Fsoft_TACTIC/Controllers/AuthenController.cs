using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsoft_TACTIC.Controllers
{
    public class AuthenController : Controller
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Rg63IvGlW1TDX5tsHxyTIBcy8GbnBd2zfX8xYAPr",
            BasePath = "https://tactic-8da8d-default-rtdb.asia-southeast1.firebasedatabase.app\r\n\r\n"
        };
        // GET: Web
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}