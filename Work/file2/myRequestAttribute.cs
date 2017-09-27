using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Work.file2
{
    public class myRequestAttribute : FilterAttribute, IResultFilter
    {
        /// <summary>
        /// 返回之前
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("OnResultExecuted");
        }
        /// <summary>
        /// 返回之后
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("OnResultExecuting");
        }
    }
}