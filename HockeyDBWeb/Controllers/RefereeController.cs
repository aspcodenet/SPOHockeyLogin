using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyDBWeb.Controllers
{
    public class RefereeController : Controller
    {
        [Authorize(Roles = "RefereeManager, Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}