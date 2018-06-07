using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using CourseProject.db.Entities;

namespace CourseProject.Models
{
    public class PropertiesViewModel : BaseViewModel
    {
        [Required]
        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Rooms { get; set; }

        [Required]
        public int Area { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public string ResidentialDistrict { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Year { get; set; }

        public string Extras { get; set; }

        public PropertiesViewModel (Property p)
        {
            Type = p.Type;
            Id = p.Id;
            Bedrooms = p.Bedrooms;
            Rooms = p.Rooms;
            Area = p.Area;
            Floor = p.Floor;
            ResidentialDistrict = p.ResidentialDistrict;
            City = p.City;
            Price = p.Price;
            Year = p.Year;
            Extras = p.Extras;
        }
    }
}