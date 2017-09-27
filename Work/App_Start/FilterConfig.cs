using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work.file2;

namespace Work.App_Start
{
    /// <summary>
    /// 全局过滤配置器
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// 注册全局过滤方法
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //实例化一个过滤器对象，然后添加到过滤器集合
            filters.Add(new myActionAttribute() );
            filters.Add(new myAuthAttribute());
        }
    }
}