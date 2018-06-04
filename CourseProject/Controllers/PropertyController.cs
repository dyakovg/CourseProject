using CourseProject.db.Entities;
using CourseProject.DataAccess.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;
using CourseProject.DataAccess;
using CourseProject.Models;

namespace CourseProject.Controllers
{
    public class PropertyController : Controller
    {

        private readonly CourseProjectDbContext Context;
        private BaseRepository<Property> repo;

        public PropertyController(CourseProjectDbContext ctx)
        {
            Context = ctx;
            repo = new BaseRepository<Property>(Context);
        }

        public ActionResult Index()
        {
            List<Property> properties = repo.GetAll();
            List<PropertiesViewModel> model = new List<PropertiesViewModel>();

            foreach (Property p in properties)
            {
                PropertiesViewModel pm = new PropertiesViewModel()
                {
                    AllProperties = p.Type
                };

                model.Add(pm);
            }
           
           

            return View(model);
        }
    }
}