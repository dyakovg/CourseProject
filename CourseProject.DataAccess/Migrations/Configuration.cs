namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CourseProject.db.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProject.DataAccess.CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseProject.DataAccess.CourseProjectDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddOrUpdate(x => x.Id,
                    new User() { Id = 1 , FirstName= "Georgi" , LastName = "Dyakov", Username = "gdqkov", Email = "g.dqkov3@abv.bg", Password = "12565896", RoleId = 1 },
                    new User() { Id = 2, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov2", Email = "g.dqkov4@abv.bg", Password = "12565896", RoleId = 2 },
                    new User() { Id = 3, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov3", Email = "g.dqkov5@abv.bg", Password = "12565896", RoleId = 3 },
                    new User() { Id = 4, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov4", Email = "g.dqkov6@abv.bg", Password = "12565896", RoleId = 4 },
                    new User() { Id = 5, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov5", Email = "g.dqkov7@abv.bg", Password = "12565896", RoleId = 5 }
                    );
            }
            context.SaveChanges();
        }
    }
}
