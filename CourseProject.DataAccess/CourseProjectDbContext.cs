
namespace CourseProject.DataAccess
{ 
    using System.Data.Entity;
    using CourseProject.db.Entities;
    class CourseProjectDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}
