using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_VS2015_CiCd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Dessploy with auto deply with vs 2015";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page auto deploy test new 2015";

            return View();
        }
    }
}