using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kosmisch.Sample.GroupwareApp.Filters
{
    public class LogFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var req = filterContext.HttpContext.Request;
            Trace.WriteLine($"Action Executing.|Path={req.Path}");
        }
    }
}