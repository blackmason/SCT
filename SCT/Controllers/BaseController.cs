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

        public ActionResult SetMenus()
        {
            IBaseDataAccessHelper baseDA = new BaseDataAccessHelper();
            IMenuHelper menuHelper = new MenuHelper();
            menuHelper.SetBaseDA(baseDA);

            var menus = menuHelper.GetAllMenus();
            return Json(menus, JsonRequestBehavior.AllowGet);
        }
    }

}
