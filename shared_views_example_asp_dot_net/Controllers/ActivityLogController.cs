using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class ActivityLogController : Controller
    {
        // GET: ActivityLog
        public ActionResult Index()
        {
            return View("_ActivityLog_Log");
        }

        public ActionResult Log()
        {
            return View("_ActivityLog_Log");
        }

        public ActionResult Type()
        {
            return View("_ActivityLog_logtype");
        }
    }
}