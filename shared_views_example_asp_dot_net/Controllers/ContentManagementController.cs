using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class ContentManagementController : Controller
    {
        // GET: ContentManagement
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Topics()
        {
            return View("Topics");
        }

        public ActionResult MessageTemplates()
        {
            return View("MessageTemplates");
        }

        public ActionResult Polls()
        {
            return View("Polls");
        }

        public ActionResult Survey()
        {
            return View("Survey");
        }
    }
}