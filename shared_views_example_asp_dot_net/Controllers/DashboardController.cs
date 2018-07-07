using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashboardEMUAdmin()
        {
            return View("DashboardEMUAdmin");
        }


        public ActionResult DashboardDormManager()
        {
            return View("DashboardDormManager");
        }
    }
}