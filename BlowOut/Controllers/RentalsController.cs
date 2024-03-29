﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;
using BlowOut.DAL;
using System.Data.SqlClient;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        //db object
        BlowOutContext db = new BlowOutContext();
        //keep track of count of instruments
        public static int countID = 1;
        //updated with most recent instrument info
        public static Instrument instrument = new Instrument();


        //return basic views
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

      //evaluate whether they chose new or used, then add it to the db and set the most recent instrument with the right info to display in the view
        public ActionResult ClarinetPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$35 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Clarinet', 'New', 35)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Clarinet"; instrument.Type = "New"; instrument.Price = 35;
            }
            else
            {
                ViewBag.Price = "$27 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Clarinet', 'Used', 27)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Clarinet"; instrument.Type = "Used"; instrument.Price = 27;
            }

            countID++;
            return View("RentalPriceDisplay");
        }
        public ActionResult FlutePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$40 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Flute', 'New', 40)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Flute"; instrument.Type = "New"; instrument.Price = 40;
            }
            else
            {
                ViewBag.Price = "$25 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Flute', 'Used', 25)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Flute"; instrument.Type = "Used"; instrument.Price = 25;
            }

            countID++;
            return View("RentalPriceDisplay");

        }
        public ActionResult SaxophonePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$42 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Saxophone', 'New', 42)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Saxophone"; instrument.Type = "New"; instrument.Price = 42;
            }
            else
            {
                ViewBag.Price = "$30 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Saxophone', 'Used', 30)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Saxophone"; instrument.Type = "Used"; instrument.Price = 30;
            }

            countID++;
            return View("RentalPriceDisplay");
        }
        public ActionResult TrombonePrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$60 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Trombone', 'New', 60)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Trombone"; instrument.Type = "New"; instrument.Price = 60;
            }
            else
            {
                ViewBag.Price = "$35 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Trombone', 'Used', 35)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Trombone"; instrument.Type = "Used"; instrument.Price = 35;
            }

            countID++;
            return View("RentalPriceDisplay");
        }
        public ActionResult TrumpetPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "$55 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Trumpet', 'New', 55)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Trumpet"; instrument.Type = "New"; instrument.Price = 55;
            }
            else
            {
                ViewBag.Price = "$25 a month";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Trumpet', 'Used', 25)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Trumpet"; instrument.Type = "Used"; instrument.Price = 25;
            }

            countID++;
            return View("RentalPriceDisplay");
        }
        public ActionResult TubaPrice(int type)
        {
            if (type == 1)
            {
                ViewBag.Price = "70 dollars";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Tuba', 'New', 70)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Tuba"; instrument.Type = "New"; instrument.Price = 70;
            }
            else
            {
                ViewBag.Price = "50 dollars";
                db.Database.ExecuteSqlCommand("Insert Into Instrument (Instrument_ID, Instrument_Description, Type, Price) VALUES (@countID, 'Tuba', 'Used', 50)", new SqlParameter("countID", countID));
                instrument.Instrument_Description = "Tuba"; instrument.Type = "Used"; instrument.Price = 50;
            }

            countID++;
            return View("RentalPriceDisplay");
        }

    }
}