using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTez.Models
{
    public class ResponsiblePerson
    {
        [Key]
        public int res_id { get; set; }

        [Required, Display(Name = "Name"), MaxLength(250)]
        public string Name { get; set; }

        [Required, Display(Name = "Surname"), MaxLength(250)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-posta gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        [Display(Name = "Eposta"), MaxLength(250)]
        public string Eposta { get; set; }

        
        [DataType(DataType.Password)]
        [Required,Display(Name = "Password")]
        public string password { get; set; }

        public int? dep_id { get; set; }

        public virtual Department Department { get; set; }

    }
}