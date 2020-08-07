﻿using System.Web.Mvc;

namespace Kosmisch.Sample.GroupwareApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.LogFilter());
        }
    }
}
