using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TIYSports.Models;

namespace TIYSports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new TIYSports.ViewModels.SportsHomePage();
            vm.Sports = new List<SportTypes>
            {
                new SportTypes{ SportImg="/Images/football1.jpg"},

                new SportTypes{ SportImg="/Images/golf1.jpg"},

                new SportTypes{ SportImg="/Images/swimming1.jpg"},

                new SportTypes{ SportImg="/Images/quidditch1.jpg"},

                new SportTypes{ SportImg="/Images/swimming1.jpg"},

                new SportTypes{ SportImg="/Images/cohort7.jpg"},

                new SportTypes{ SportImg="/Images/pingpong1.jpg"},

                new SportTypes{ SportImg="/Images/basketball1.jpg"},
                //new SportTypes{ Sport = "Ping Pong", SportImg="/Images/basketball1.jpg"},

            };
            return View(vm);
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