using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArabianRomanNumericalTranslator;

namespace RomanNumericalTranslator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult CalculatorView()
        {
            return View();
        }
       
        public ActionResult About()
        {
            return View();
        }

        public string Translate(string input, string translation)
        {
            if (translation == "arabian")
            {
                if (!String.IsNullOrEmpty(input))
                {
                    try
                    {
                        int value = Int32.Parse(input);
                        return ArabianToRoman.Translate(value).ToString();
                    }
                    catch
                    {
                        return ("Błąd");
                    }

                }
                else
                    return String.Empty;

            }
            else
            {
                return RomanToArabian.Translate(input).ToString();
            }
        }

    }
}