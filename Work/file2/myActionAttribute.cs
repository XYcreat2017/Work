using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using Work.file2;

namespace Work.file2
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
    public class myActionAttribute : FilterAttribute, IActionFilter
    {
        public string Message { get; set; }
        /// <summary>
        /// Action方法执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine($"OnActionExecuted:{Message}");
        }
        /// <summary>
        /// Action方法执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine($"OnActionExecuted:{Message}");
        }
    }
}