using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult Reported()
        {
            return View("Reported");
        }

        public ActionResult Flagged()
        {
            return View("Flagged");
        }

        public ActionResult Deleted()
        {
            return View("Deleted");
        }

       
    }
}