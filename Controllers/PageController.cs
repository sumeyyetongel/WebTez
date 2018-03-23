using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTez.Models;

namespace WebTez.Controllers
{
    public class PageController : Controller
    {
        MfgDBContext db = new MfgDBContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Responsibleprofile()
        {
            return View();
        }
    }
}