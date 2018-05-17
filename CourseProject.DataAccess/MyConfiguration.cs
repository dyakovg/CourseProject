
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace CourseProject.DataAccess
{
    class MyConfiguration : DbConfiguration
    {
        public MyConfiguration()
        {
            SetDefaultConnectionFactory(
                new LocalDbConnectionFactory("MSSQLLocalDB")
                );
        }
    }
}
