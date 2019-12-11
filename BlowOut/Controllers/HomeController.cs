using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;
using BlowOut.DAL;
using System.Web.Security;

//Savannah Bird, Kent Broadbent, Whitney Graham, Michael Chadwick - 12/11/19 - Checkpoint 5
//Description - this website will allow users to login to rent/buy instruments from BlowOut Instrument rentals

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        BlowOutContext db = new BlowOutContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are an awesome company that sells cheap instruments. Here are our founders.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }

        //POST Login, needs to match username and password
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(userName, "Missouri") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("UpdateData", "Customers");

            }
            else
            {
                return View();
            }
        }
    }
}