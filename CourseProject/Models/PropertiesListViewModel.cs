using CourseProject.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    public class PropertiesListViewModel : BaseViewModel
    {
        public List<Property> Property { get; set; }
    }
}