using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class Student
    {

        [Key]
        public int stu_id { get; set; }

        [Required, Display(Name = "Name"), MaxLength(250)]
        public string Name { get; set; }
        [Required, Display(Name = "Surname"), MaxLength(250)]
        public string Surname { get; set; }
        [Required, Display(Name = "StudentNumber")]
        public int StudentNumber { get; set; }

        [Required, Display(Name = "PhoneNumber"), MaxLength(250)]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "Eposta"), MaxLength(250)]
        public string Eposta { get; set; }

        [Required, Display(Name = "HomeAddress"), MaxLength(250)]
        public string HomeAddress { get; set; }

        [Required, Display(Name = "InputDate"), MaxLength(250)]
        public string InputDate { get; set; }

        [Required, Display(Name = "GraduateDate"), MaxLength(250)]
        public string GraduateDate { get; set; }

        [Required, Display(Name = "GradeAverage")]
        public int GradeAverage { get; set; }

        [Required, Display(Name = "PreparationInformation"), MaxLength(250)]
        public string PreparationInformation { get; set; }

        [Required, Display(Name = "password"), MaxLength(250)]
        public string password { get; set; }

        public virtual ResponsiblePerson Responasible_ID { get; set; }
    }
}