using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class Facultie
    {
        [Key]
        public int fak_id { get; set; }

        [Required, Display(Name = "FacultyName"), MaxLength(150)]
        public string FacultyName { get; set; }

        public virtual int University_ID { get; set; }

        public virtual Universitiy Universitiy { get; set; }



    }
}