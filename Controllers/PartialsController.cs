using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTez.Models;
using WebTez.ViewModel;

namespace WebTez.Controllers
{
    public class PartialsController : Controller
    {
        MfgDBContext db = new MfgDBContext();
       public PartialViewResult Selects()
        {
            MfgDBContext db = new MfgDBContext();
            State model = new State();
            
            List<Province> provinceList = db.Province.OrderBy(f => f.proviceName).ToList();
            model.proList = (from s in provinceList
                               select new SelectListItem
                               {
                                   Text = s.proviceName,
                                   Value = s.pro_id.ToString()
                               }).ToList();
            model.proList.Insert(0, new SelectListItem { Text = "Seçiniz", Value = "", Selected = true });
            ViewBag.den = model.DepList;
            return PartialView(model);
        }
        [HttpPost]
        public JsonResult UniList(int ID)
        {
            MfgDBContext db = new MfgDBContext();
            List<Universitiy> unilist = db.Universitiy.Where(u => u.Province_ID == ID).OrderBy(u => u.UniversityName).ToList();
            List<SelectListItem> itemList = (from i in unilist
                                             select new SelectListItem
                                             {
                                                 Value = i.uni_id.ToString(),
                                                 Text=i.UniversityName
                                             }).ToList();
            return Json(itemList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]

        public JsonResult FakList(int ID)
        {
            MfgDBContext db = new MfgDBContext();
            List<Facultie> fakilist = db.Facultie.Where(f=>f.University_ID == ID).OrderBy(u => u.FacultyName).ToList();
            List<SelectListItem> itemList = (from i in fakilist
                                             select new SelectListItem
                                             {
                                                 Value = i.fak_id.ToString(),
                                                 Text = i.FacultyName
                                             }).ToList();
            return Json(itemList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]

        public JsonResult DepList(int ID)
        {
            MfgDBContext db = new MfgDBContext();
            List<Department> deplist = db.Department.Where(u => u.Faculty_id == ID).OrderBy(u => u.DepartmentName).ToList();
            List<SelectListItem> itemList = (from i in deplist
                                             select new SelectListItem
                                             {
                                                 Value = i.dep_id.ToString(),
                                                 Text = i.DepartmentName
                                             }).ToList();
            return Json(itemList, JsonRequestBehavior.AllowGet);
        }

    }
}