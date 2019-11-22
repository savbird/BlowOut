using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Clarinet()
        {
            return View();
        }
        public ActionResult Flute()
        {
            return View();
        }
        public ActionResult Saxophone()
        {
            return View();
        }
        public ActionResult Trombone()
        {
            return View();
        }
        public ActionResult Trumpet()
        {
            return View();
        }
        public ActionResult Tuba()
        {
            return View();
        }

      
        public ActionResult ClarinetPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$35 a month";
            }
            else
            {
                ViewBag.Price = "$27 a month";
            }

            return View("RentalPriceDisplay");
        }
        public ActionResult FlutePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$40 a month";
            }
            else
            {
                ViewBag.Price = "$25 a month";
            }
            
            return View("RentalPriceDisplay");
        }
        public ActionResult SaxophonePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$42 a month";
            }
            else
            {
                ViewBag.Price = "$30 a month";
            }

            return View("RentalPriceDisplay");
        }
        public ActionResult TrombonePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$60 a month";
            }
            else
            {
                ViewBag.Price = "$35 a month";
            }

            return View("RentalPriceDisplay");
        }
        public ActionResult TrumpetPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$55 a month";
            }
            else
            {
                ViewBag.Price = "$25 a month";
            }

            return View("RentalPriceDisplay");
        }
        public ActionResult TubaPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "70 dollars";
            }
            else
            {
                ViewBag.Price = "50 dollars";
            }

            return View("RentalPriceDisplay");
        }

    }
}