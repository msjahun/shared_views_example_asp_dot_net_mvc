using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Information()
        {
            return View("Information");
        }

        public ActionResult Log()
        {

            return View("Log");
        }

        public ActionResult Warnings()
        {
            return View("Warnings");
        }

        public ActionResult Maintenance()
        {
            return View("Maintenance");
        }

        public ActionResult MessageQueues()
        {
            return View("MessageQueues");
        }
        public ActionResult ScheduleTasks()
        {
            return View("ScheduleTasks");
        }
        public ActionResult SEOFriendlyPageNames()
        {
            return View("SEOFriendlyPageNames");
        }
    }
}