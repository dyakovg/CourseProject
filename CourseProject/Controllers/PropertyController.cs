using CourseProject.db.Entities;
using CourseProject.DataAccess.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;
using CourseProject.DataAccess;

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
            List<Property> model = repo.GetAll();

            return View(model);
        }
    }
}