using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class InternshipInformation
    {
        [Key]
        public int inter_id { get; set; }

        [Required, Display(Name = "InternshipDate"), MaxLength(250)]
        public string InternshipDate { get; set; }

        [Required, Display(Name = "CorporationName"), MaxLength(250)]
        public string CorporationName { get; set; }

        [Required, Display(Name = "DepartmentName"), MaxLength(250)]
        public string DepartmentName { get; set; }

        public virtual Student Student_ID { get; set; }

    }
}