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
            if (!context.Roles.Any())
            {
                context.Roles.AddOrUpdate(x => x.Id,
                    new Role { Id = 1, Name = "Administrator" },
                    new Role { Id = 2, Name = "Regular" }
                );

                context.SaveChanges();
            }


            if (!context.Users.Any())
            {
                context.Users.AddOrUpdate(x => x.Id,
                    new User() { Id = 1 , FirstName= "Georgi" , LastName = "Dyakov", Username = "gdqkov", Email = "g.dqkov3@abv.bg", Password = "12565896", RoleId = 1 },
                    new User() { Id = 2, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov2", Email = "g.dqkov4@abv.bg", Password = "12565896", RoleId = 1 },
                    new User() { Id = 3, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov3", Email = "g.dqkov5@abv.bg", Password = "12565896", RoleId = 2 },
                    new User() { Id = 4, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov4", Email = "g.dqkov6@abv.bg", Password = "12565896", RoleId = 2 },
                    new User() { Id = 5, FirstName = "Georgi", LastName = "Dyakov", Username = "gdqkov5", Email = "g.dqkov7@abv.bg", Password = "12565896", RoleId = 2 }
                    );

                context.SaveChanges();
            }

            if (!context.Properties.Any())
            {
                context.Properties.AddOrUpdate(x => x.Id,
                new Property() { Id = 1, Type = "Apartament", Bedrooms = 2, Rooms = 5, Area = 5, Floor = 1, ResidentialDistrict = "Pishmana", City = "Veliko Tarnovo", Price = 39999, Year = 1998, Extras = "Small Garden, Parking lot" },
                new Property() { Id = 2, Type = "Apartament", Bedrooms = 1, Rooms = 2, Area = 4, Floor = 8, ResidentialDistrict = "Sini Kamani", City = "Sliven", Price = 80999, Year = 2004, Extras = "Beautiful View, Schools in area " }

                );

                context.SaveChanges();
            }
            
        }
    }
}
