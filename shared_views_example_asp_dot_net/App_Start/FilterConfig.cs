﻿using System.Web;
using System.Web.Mvc;

namespace shared_views_example_asp_dot_net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
