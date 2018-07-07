using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class ConfigurationsController : Controller
    {
        // GET: Configurations
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmailAccounts()
        {
            return View("EmailAccounts");
        }

        public ActionResult Dormitories()
        {
            return View("Dormitories");
        }

        public ActionResult Countries()
        {
            return View("Countries");
        }

        public ActionResult Languages()
        {
            return View("Languages");
        }

        public ActionResult AccessControlList()
        {
            return View("AccessControlList");
        }

        public ActionResult Currencies()
        {
            return View("Currencies");
        }



    }
}