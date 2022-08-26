using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxHelperDemo.Models;

namespace AjaxHelperDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Emp emp)
        {
            return Json("true",JsonRequestBehavior.AllowGet);   
        }
    }
}