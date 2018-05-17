

namespace CourseProject.db.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class User : BaseEntity
    {
        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required, StringLength(20)]
        [Index(IsUnique =true)]
        public string Username { get; set; }

        [Required, StringLength(20), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), StringLength(64)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required, ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

    }
}
