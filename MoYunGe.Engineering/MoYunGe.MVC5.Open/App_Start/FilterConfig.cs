﻿using System.Web;
using System.Web.Mvc;

namespace MoYunGe.MVC5.Open
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
