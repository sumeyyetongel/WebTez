using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class Universitiy
    {
        [Key]
        public int uni_id { get; set; }

        [Required, Display(Name = "UniversityName"), MaxLength(150)]
        public string UniversityName { get; set; }
        public virtual int Province_ID { get; set; }

        public virtual Province province { get; set; }


    }
}