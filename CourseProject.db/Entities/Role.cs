using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.db.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Role : BaseEntity
    {
        [Required, StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
