using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
namespace Work.file2
{
    /// <summary>
    /// 创建一个以Attribute结尾的类
    /// </summary>
    public class myAuthAttribute : FilterAttribute, IAuthorizationFilter
    {
        /// <summary>
        /// 创建身份验证的事件
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //获取请求的控制器名称
            var controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (controller == "Login") return;
            //判断是否有session如果没有就不能登陆
            if (filterContext.HttpContext.Session["user"] == null)
            {
                //创建一个UrlHelper对象传递一个上下文对象，否则找不到路由配置
                var url = new UrlHelper(filterContext.RequestContext);
                //实例化一个重定向结果对象，返回到登录页面
                filterContext.Result = new RedirectResult(url.Action("Index", "Login"));
            }
        }
    }
}