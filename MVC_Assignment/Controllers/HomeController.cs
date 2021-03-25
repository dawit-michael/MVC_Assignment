using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            var images = new string[3] { "../images/amazon-echo-dot-4th-gen.png", "../images/echo-dot-with-clock-4th-gen-2020-official-render.png", "../images/amazon-echo-dot-4th-gen-smart-speaker-w-alexa-w-clock-w-alexa-glacier-white-d-b07xj8c8f7.png", };
            var colors = new string[3] { "Black", "Gray", "White" };
            var prices = new Int16[3] { 220, 160, 200 };
            ViewBag.Images = images;
            ViewBag.Colors = colors;
            ViewBag.Prices = prices;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Amazon()
        {
            var url = "http://www.Amazon.com";
            return Redirect(url);
        }
        public ActionResult Download()
        {
            var file = "../documents/Using_random_forests_V3.1.pdf";
            return File(file, contentType: "Application/pdf");
        }

    }
}