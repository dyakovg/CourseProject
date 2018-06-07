using CourseProject.DataAccess.Repositories;
using CourseProject.db.Entities;
using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*PropertyRepository property = new PropertyRepository();
            Property Apartament = new Property() { Id = 4, Type = "Penthouse", Bedrooms = 3, Rooms = 9, Area = 2, Floor = 2, ResidentialDistrict = "Sini Kamani", City = "Sliven", Price = 180999, Year = 2016, Extras = "Beautiful View, Schools in area " };
            property.Save(Apartament);*/

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