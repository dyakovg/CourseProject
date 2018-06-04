using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CourseProject.db.Entities;

namespace CourseProject.Models
{
    public class PropertiesViewModel
    {
        public List<Property> AllProperties { get; set; }

        public List<Property> GetProperties()
        {
            return AllProperties;
        }
    }
}