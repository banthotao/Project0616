using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410828739_0616.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, int num)
        {
            var result = "";

            if (num == 13)
            {
                result = "下午1點";
            }
            else if (num == 14)
            {
                result = "下午2點";
            }
            else if (num == 15)
            {
                result = "下午3點";
            }
            else if (num == 16)
            {
                result = "下午4點";
            }
            else if (num == 17)
            {
                result = "下午5點";
            }
            else if (num == 18)
            {
                result = "下午6點";
            }
            else
            {
                result = "錯誤";
            }

            ViewBag.Name = name;
            ViewBag.Result = result;

            return View();
        }
    }

}