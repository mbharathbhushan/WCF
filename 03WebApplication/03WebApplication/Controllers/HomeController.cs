using _03WebApplication.HttpService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private HelloServiceClient helloServiceClient;

        public HomeController()
        {
            helloServiceClient = new HelloServiceClient("BasicHttpBinding_IHelloService");
        }

        public ActionResult Index()
        {
           ViewBag.httpServiceMessage = helloServiceClient.GetMessage(DateTime.Now.ToString());

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