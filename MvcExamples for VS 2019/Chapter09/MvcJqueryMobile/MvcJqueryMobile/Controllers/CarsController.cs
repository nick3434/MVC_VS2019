using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcJqueryMobile.Models;

namespace MvcJqueryMobile.Controllers
{
    public class CarsController : Controller
    {
        MobileContext db = new MobileContext();

        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CarsList()
        {
            return View();
        }

        public ActionResult Repair()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        //從資料庫讀取Car資料
        public ActionResult CarsListDB()
        {
            //讀取Car資料表，並依Category車類型排序
            var cars = db.Cars.OrderBy(x => x.Category).ToList();
            return View(cars);
        }

        //Table: Reflow
        public ActionResult RepairReflow()
        {
            return View();
        }
    }
}