using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class WorkingInformation
    {
        [Key]
        public int work_id { get; set; }

        [Required, Display(Name = "CorporationName"), MaxLength(250)]
        public string CorporationName { get; set; }
        [Required, Display(Name = "DepartmentName"), MaxLength(250)]
        public string DepartmentName { get; set; }

        [Required, Display(Name = "PozitionName"), MaxLength(250)]
        public string PozitionName { get; set; }

        [Required, Display(Name = "proviceName"), MaxLength(250)]
        public string proviceName { get; set; }

        [Required, Display(Name = "InputDate"), MaxLength(250)]
        public string InputDate { get; set; }

        [Required, Display(Name = "OutputDate"), MaxLength(250)]
        public string OutputDate { get; set; }

        [Required, Display(Name = "Explanation"), MaxLength(250)]
        public string Explanation { get; set; }

        public virtual Student Student_ID { get; set; }

    }
}