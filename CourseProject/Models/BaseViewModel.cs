using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    abstract public class BaseViewModel
    {
        [Required]
        public int Id { get; set; }
    }
}