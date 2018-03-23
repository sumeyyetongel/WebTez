using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebTez.Models;
using WebTez.ViewModel;

namespace WebTez.Controllers
{
    [Authorize, SessionExpire]
    public class AdminController : Controller
    {
        MfgDBContext db = new MfgDBContext();

        public ActionResult Index()
        {
           return View();
        }
        //Login işlemleri
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public ActionResult Login(FormCollection form)
        {
        
           
            string username = form["Eposta"].ToString();
            string passwords = form["password"].ToString();
            ResponsiblePerson user = db.ResponsiblePerson.Where(x => x.Eposta == username && x.password == passwords).FirstOrDefault();
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Eposta, false);
                Session["Ad"] = user.Name;
                Session["Soyad"]=user.Surname;
                Session["Eposta"] = user.Eposta;
                Session["password"] = user.password;
                Session["departman"] = user.Department.DepartmentName;
               // Session["universite"] = user.Department.Facultie.Universitiy.UniversityName;
                Session["id"] = user.res_id;

                //Session["Rol"] = user.Role;
                //if (user.Role == "Admin")
                //{
                //    return RedirectToAction("Index", "Admin");
                //}
                return RedirectToAction("Responsibleprofile", "Page");
            }
            TempData["Message"] = Alert("Hatalı giriş yaptınız.", false);
            return View();
        }
        [AllowAnonymous]

        public ActionResult Logout()
        {
            Session["Eposta"] = null;
            return RedirectToAction("Index","Page");
        }

        public ActionResult ForgotPassword()
        {
        
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(Student user)
        {
            Student dbUser = db.Student.Where(x => x.Name == user.Name && x.Surname == user.Surname && x.StudentNumber == user.StudentNumber && x.PhoneNumber == user.PhoneNumber && x.Eposta == user.Eposta && x.HomeAddress == user.HomeAddress && x.InputDate == user.InputDate && x.GraduateDate == user.GraduateDate && x.GradeAverage == user.GradeAverage && x.PreparationInformation == user.PreparationInformation).FirstOrDefault();
            return View(dbUser);
        }
        //Register işlemleri
        [AllowAnonymous]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public ActionResult CreateUser(ResponsiblePerson newitem)
        {
         
            db.ResponsiblePerson.Add(newitem);
            db.SaveChanges();
            return RedirectToAction("Index", "Page");
        }

        public ActionResult EditUser(int? Id)
        {
            int userID = Convert.ToInt32(Session["UserId"]);
            if (Id != userID && Session["Rol"].ToString() != "Admin")
            {
                Id = userID;
            }
            Student item = db.Student.Where(x => x.stu_id == Id).FirstOrDefault();
            if (item == null)
            {
                return RedirectToAction("User", "Admin");
            }
            return View(item);
        }

        public ActionResult UpdateUser(Student newitem)
        {
            string actionPage = null;
            Student item = db.Student.Where(x => x.stu_id == newitem.stu_id).FirstOrDefault();
            if (item != null)
            {
                item.Name = newitem.Name;
                item.Surname = newitem.Surname;

                db.SaveChanges();
                TempData["Message"] = Alert("Kullanıcı güncellendi.", true);
            }
            else
            {
                TempData["Message"] = Alert("Hata oluştu! Kullanıcı güncellenemedi.", false);
            }
            return RedirectToAction(actionPage, "Admin");
        }

        public ActionResult DeleteUser(int Id)
        {
            Student item = db.Student.Where(x => x.stu_id == Id).FirstOrDefault();
            if (item != null)
            {
                db.Student.Remove(item);
                db.SaveChanges();
                TempData["Message"] = Alert("Kullanıcı silindi", true);
            }
            else
            {
                TempData["Message"] = Alert("Hata oluştu! Kullanıcı silinemedi.", false);
            }
            return RedirectToAction("Users", "Admin");
        }

        public string Alert(string message, bool? type = null)
            {
                string tip;
                switch (type)
                {
                    case false: tip = "danger"; break;
                    case true: tip = "success"; break;
                    default:
                        tip = "info";
                        break;
                }
                string msg = "<div class='alert alert-" + tip + " alert-dismissible'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>" + message + "</div>";
                return msg;
            }

        }
    
}