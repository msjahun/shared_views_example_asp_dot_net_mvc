using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class MobileAppManagerController : Controller
    {
        // GET: MobileAppManager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendPushNotifications()
        {
            return View("SendPushNotifications");
        }

        public ActionResult UsageReport()
        {
            return View("UsageReport");
        }
    }
}