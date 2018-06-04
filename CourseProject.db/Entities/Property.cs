

namespace CourseProject.db.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Property : BaseEntity
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PropertyId { get; set; }

        [Required, StringLength(20)]
        public string Type { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Rooms { get; set; }
        
        [Required]
        public int Area { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required, StringLength(20)]
        public string ResidentialDistrict { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Year { get; set; }

        [StringLength(100)]
        public string Extras { get; set; }
    }
}
