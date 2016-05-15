using SCT.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCT.Controllers
{
    public class BaseController : Controller
    {
        private IMenuHelper menuHelper;
        public BaseController(IMenuHelper menuHelper)
        {
            this.menuHelper = menuHelper;
        }

        public ActionResult SetMenus()
        {
            MenuHelper menuHelper = new MenuHelper();
            var menus = menuHelper.GetAllMenus();
            return Json(menus, JsonRequestBehavior.AllowGet);
        }
    }
}
