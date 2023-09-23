using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai1.Areas.Adim.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Adim/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}