using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task17_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetResult(string txtNum1, string txtNum2, string chkSelect)
        {
            int a = Convert.ToInt32(txtNum1);
            int b = Convert.ToInt32(txtNum2);
            if(chkSelect == "1")
            {
                ViewBag.Result = "Addition Result is " + (a + b).ToString();
            }
            else
            {
                ViewBag.Result = "Subtraction Result is " + (a - b).ToString();
            }
            return View("Index");
        }

        
    }
}