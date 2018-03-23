using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTez.ViewModel
{
    public class State
    {
        public State()
        {
            this.uniList = new List<SelectListItem>();
            uniList.Add(new SelectListItem { Text = "Seçiniz", Value = "" });

            this.fakList = new List<SelectListItem>();
            fakList.Add(new SelectListItem { Text = "Seçiniz", Value = "" });

            this.DepList = new List<SelectListItem>();
            DepList.Add(new SelectListItem { Text = "Seçiniz", Value = "" });
        }
        public int pro_id { get; set; }
        public int uni_id { get; set; }
        public int fak_id { get; set; }
        public int dep_id { get; set; }

        public List<SelectListItem> proList { get; set; }
        public List<SelectListItem> uniList { get; set; }

        public List<SelectListItem> fakList { get; set; }
        public List<SelectListItem> DepList { get; set; }



    }
}