
namespace CourseProject.DataAccess
{ 
    using System.Data.Entity;
    using CourseProject.db.Entities;
    public class CourseProjectDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Property> Properties { get; set; }
    }
}
