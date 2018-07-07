using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class HelpController : Controller
    {
        // GET: Help
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Topics()
        {
            return View("Topics");
        }

        public ActionResult FAQ()
        {

            return View("FAQ");
        }
    }
}