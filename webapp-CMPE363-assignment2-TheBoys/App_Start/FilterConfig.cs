﻿using System.Web;
using System.Web.Mvc;

namespace webapp_CMPE363_assignment2_TheBoys
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
