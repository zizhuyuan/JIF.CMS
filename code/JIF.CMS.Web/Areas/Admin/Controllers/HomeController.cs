using JIF.CMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JIF.CMS.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.sysAdmins = new SysAdminServices().Load();
            return View();
        }

        public ViewResult Detail(int id)
        {
            ViewBag.Admin = new SysAdminServices().Load(id);
            return View();
        }
    }
}