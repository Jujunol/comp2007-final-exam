using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2006_S2016_FinalExamV2.Controllers
{

    //Author: John Horne
    //Student ID: 200240927
    //Date Modified: 08/18/16
    //File History: initial commit
    //File Description: Routes pages about, index, and contact pages
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}