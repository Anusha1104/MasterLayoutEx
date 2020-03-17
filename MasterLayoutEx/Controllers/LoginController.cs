using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [ActionName("Home")]
        public ActionResult LoginPage()
        {
            return View();
        }
    }
}