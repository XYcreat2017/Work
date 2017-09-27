using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Diagnostics;
using Work.file2;

namespace Work.Controllers 
{
             [myAction(Message ="Controller")] 
   public class HomeController : Controller
    {
     
          [myAuth] 
        /// <summary>
        /// 在Web中设置
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile="Cache1Hour")]
        // GET: Home
        public ActionResult Index()
        {
            //throw new Exception("Exception-Index-Aection");
            //Debug.WriteLine("Action");
            ViewBag.time = DateTime.Now;
            return View();
        }
        /// <summary>
        /// 在页面中设置
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration =5)]
        public ActionResult Fake()
        {
            ViewBag.time = DateTime.Now;
            return View();
        }
        public ActionResult Add()
        {
            return Content("Add");
        }
    }
}