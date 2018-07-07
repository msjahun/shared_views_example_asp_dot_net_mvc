using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class PromotionsController : Controller
    {
        // GET: Promotions
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Discounts()
        {
            return View("Discounts");
        }



        public ActionResult Affiliates()
        {
            return View("Affiliates");
        }



        public ActionResult NewsLetterSubscribers()
        {
            return View("NewsLetterSubscribers");
        }


        public ActionResult Campaigns()
        {
            return View("Campaigns");
        }


    }
}