using CourseProject.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repositories
{
    class UserRepository : BaseRepository<User>
    {
        public void Save(User User)
        {
            if (User.Id == 0)
            {
                Create(User);
            }
            else
            {
                Update(User, item => item.Id == User.Id);
            }
        }
    }
}
