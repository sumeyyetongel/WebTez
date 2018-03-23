using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class Province
    {
        [Key]
        public int pro_id { get; set; }

        [Required, Display(Name = "proviceName"), MaxLength(150)]
        public string proviceName { get; set; }

    }
}