using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View("Settings");
        }

        public ActionResult Client()
        {
            return View("Client");
        }

        public ActionResult Doc()
        {
            return View("Doc");
        }
    }
}