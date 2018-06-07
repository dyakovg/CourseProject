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
                    new User() { Id = 2, FirstName = "Ivan", LastName = "Petrov", Username = "vankata", Email = "vanio@abv.bg", Password = "12565896", RoleId = 1 },
                    new User() { Id = 3, FirstName = "Petkan", LastName = "Syarov", Username = "petkancho", Email = "patkan@abv.bg", Password = "12565896", RoleId = 2 },
                    new User() { Id = 4, FirstName = "Stefan", LastName = "Stambolov", Username = "stefcho", Email = "stefcho@abv.bg", Password = "12565896", RoleId = 2 },
                    new User() { Id = 5, FirstName = "Djordan", LastName = "Kesov", Username = "djordji", Email = "drjodji@abv.bg", Password = "12565896", RoleId = 2 }
                    );

                context.SaveChanges();
            }

            if (!context.Properties.Any())
            {
                context.Properties.AddOrUpdate(x => x.Id,
                new Property() { Id = 1, Type = "Apartament", Bedrooms = 2, Rooms = 5, Area = 5, Floor = 1, ResidentialDistrict = "Pishmana", City = "Veliko Tarnovo", Price = 39999, Year = 1998, Extras = "Small Garden, Parking lot" },
                new Property() { Id = 2, Type = "Apartament", Bedrooms = 1, Rooms = 2, Area = 1, Floor = 3, ResidentialDistrict = "Sini Kamani", City = "Sliven", Price = 80999, Year = 2004, Extras = "Beautiful View, Schools in area " },
                new Property() { Id = 3, Type = "House", Bedrooms = 1, Rooms = 4, Area = 5, Floor = 1, ResidentialDistrict = "Drujba", City = "Sliven", Price = 50000, Year = 2005, Extras = "Small Garden, Parking lot" },
                new Property() { Id = 4, Type = "Penthouse", Bedrooms = 3, Rooms = 9, Area = 2, Floor = 2, ResidentialDistrict = "Sini Kamani", City = "Sliven", Price = 180999, Year = 2016, Extras = "Beautiful View, Schools in area " }


                );

                context.SaveChanges();
            }
            
        }
    }
}
