using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class NotificationsController : Controller
    {
        // GET: Notifications
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult Announcements()
        {
            return View("Announcements");
        }

        public ActionResult ManageAnnouncements()
        {
            return View("ManageAnnouncements");
        }


    }
}