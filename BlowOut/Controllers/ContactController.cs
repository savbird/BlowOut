using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.ContactString =  "Please call Support at <b><u>801-555-1212</b></u>. Thank you!";
            return View("Index");
        }

        /*Create another method called Email that receives 2 parameters: name and email address. 
         * It also returns an html encoded string, to the view, thanking the "name" and saying that the 
         * company will send an email to the "email" parameter*/
        public ActionResult Email(string name, string email)
        {
            ViewBag.Email = "<p>Thanks " + name + ", we will send you a message at " + email + "<p>";
            return View("Email");
        }
    }
}