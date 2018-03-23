using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTez.Models
{
    public class SessionExpireAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;

            string action = filterContext.ActionDescriptor.ActionName;

            // oturumları buradan kontrol et
            if (!action.Equals("Login", StringComparison.OrdinalIgnoreCase))
            {
                if (ctx.Session["Rol"] == null || ctx.Session["Eposta"] == null)
                {
                 //  filterContext.Result = new RedirectResult("/Admin/Login");
                    return;
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}