﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCT.Controllers
{
    public class HomeController : BaseController
    {
        /* 메인화면 */
        public ActionResult Main()
        {
            return View();
        }

    }
}
