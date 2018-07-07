using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View("_Users_list");
        }

        public ActionResult List()
        {
            return View("_Users_list");
        }

        public ActionResult Roles()
        {
            return View("_User_roles_list");
        }

        public ActionResult OnlineUsers()
        {
            return View("_Users_online_users_list");
        }

        public ActionResult UsersReport()
        {
            return View("_Users_report");
        }
    }
}