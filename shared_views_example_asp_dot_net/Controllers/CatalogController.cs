using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rooms()
        {
            return View("Rooms");
        }

        public ActionResult DormitoryBlocks()
        {
            return View("DormitoryBlocks");
        }

        public ActionResult BulkRoomEdit()
        {
            return View("BulkRoomEdit");
        }

        public ActionResult LowQuotaReport()
        {
            return View("LowQuotaReport");
        }

        public ActionResult RoomReviews()
        {
            return View("RoomReviews");
        }

        public ActionResult FacilitiesSpecificationAttrs()
        {
            return View("FacilitiesSpecificationAttrs");
        }
    }
}