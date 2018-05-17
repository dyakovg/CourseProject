


namespace CourseProject.db.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Client : BaseEntity
    {
        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required, StringLength(20)]
        public string Phone { get; set; }

        [Required, StringLength(40)]
        public string Address { get; set; }

        [Required, StringLength(20)]
        [Index(IsUnique = true)]
        public int PersonalNO { get; set; }
    }
}
