﻿using System.Web;
using System.Web.Mvc;

namespace vidly_aspnet_learn
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
