

namespace CourseProject.db.Entities
{
    using System.ComponentModel.DataAnnotations;
    class Property : BaseEntity
    {
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

        [Required, StringLength(20)]
        public decimal Price { get; set; }

        [Required]
        public int Year { get; set; }

        [StringLength(100)]
        public string Extras { get; set; }
    }
}
