using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Calc(string arg1, string arg2, string math)
        {
            CalculatorWebApi.Models.TResult vdata = new Models.TResult()
            {
                arg1 = arg1,
                arg2 = arg2,
                math = math,
            };

            decimal a = 0;
            decimal b = 0;
            string result = "";

            if (!decimal.TryParse(arg1, out a) || !decimal.TryParse(arg2, out b))
                result = "введите данные";

            switch (math)
            {
                case "+":
                    result = (a + b).ToString();
                    break;
                case "-":
                    result = (a - b).ToString();
                    break;
                case "*":
                    result = (a * b).ToString();
                    break;
                case "/":
                    result = b != 0 ?
                    (a / b).ToString()
                    : "error";
                    break;
                default:
                    result = "введите данные";
                    break;
            }

            vdata.result = result;
            return View(vdata);
        }

        public ActionResult Result(string arg1, string arg2, string math)
        {
            decimal a = 0;
            decimal b = 0;
            string result = "";

            if (!decimal.TryParse(arg1, out a) || !decimal.TryParse(arg2, out b))
                result = "Не правильные аргументы";

            switch (math)
            {
                case "+":
                    result = (a + b).ToString();
                    break;
                case "-":
                    result = (a - b).ToString();
                    break;
                case "*":
                    result = (a * b).ToString();
                    break;
                case "/":
                    result = b != 0 ?
                    (a / b).ToString()
                    : "error";
                    break;
                default:
                    result = "Выбирите математическую функцию";
                    break;
            }

            return View("Calc", model: result);
        }
    }
}
