using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservations
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult CancelRequest()
        {
            return View("CancelRequest");

        }

        public ActionResult CurrentWishList()
        {
            return View("CurrentWishList");
        }

        public ActionResult BestSellerRooms()
        {
            return View("BestSellerRooms");
        }

        public ActionResult RoomsNeverReserved()
        {
            return View("RoomsNeverReserved");
        }

        public ActionResult CountryReport()
        {
            return View("CountryReport");
        }
    }
}