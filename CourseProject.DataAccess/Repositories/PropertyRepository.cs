using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.db.Entities;

namespace CourseProject.DataAccess.Repositories
{
    class PropertyRepository : BaseRepository<Property>
    {
        public void Save(Property Property)
        {
            if (Property.Id == 0)
            {
                Create(Property);
            }
            else
            {
                Update(Property, item => item.Id == Property.Id);
            }
        }
    }
}
