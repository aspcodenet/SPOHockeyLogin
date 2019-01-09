using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyDBWeb.Controllers
{
    public class PlayerController : Controller
    {

        [Authorize(Roles = "PlayerManager, Admin")]
        public ActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "PlayerManager, Admin")]
        [HttpGet]
        public ActionResult Create()
        {
            var model = new ViewModels.PlayerEditViewModel();
            return View(model);
        }

        [Authorize(Roles = "PlayerManager, Admin")]
        [HttpPost]
        public ActionResult Create(ViewModels.PlayerEditViewModel mo)
        {
            if(ModelState.IsValid)
            {

            }
            return View(mo);
        }

    }
}