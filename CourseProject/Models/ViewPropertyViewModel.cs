using CourseProject.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    public class ViewPropertyViewModel : BaseViewModel
    {
        public ViewPropertyViewModel()
        {

        }

        public ViewPropertyViewModel(Property propertyObj)
        {
            this.Id = propertyObj.Id;
            this.Type = propertyObj.Type;
            this.Bedrooms = propertyObj.Bedrooms;
            this.Rooms = propertyObj.Rooms;
            this.Area = propertyObj.Area;
            this.Floor = propertyObj.Floor;
            this.ResidentialDistrict = propertyObj.ResidentialDistrict;
            this.City = propertyObj.City;
            this.Price = propertyObj.Price;
            this.Year = propertyObj.Year;
            this.Extras = propertyObj.Extras;
        }


        public string Type { get; set; }

        public int Bedrooms { get; set; }

        public int Rooms { get; set; }

        public int Area { get; set; }

        public int Floor { get; set; }

        public string ResidentialDistrict { get; set; }

        public string City { get; set; }

        public decimal Price { get; set; }

        public int Year { get; set; }

        public string Extras { get; set; }
    }
}