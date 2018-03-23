using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class Department
    {
        [Key]
        public int dep_id { get; set; }

        [Required, Display(Name = "DepartmentName"), MaxLength(150)]
        public string DepartmentName { get; set; }

        public virtual int Faculty_id { get; set; }

        public virtual Facultie Facultie { get; set; }

    }
}