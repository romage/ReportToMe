using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReportToMe.Web.Interfaces;

namespace ReportToMe.Web.Controllers
{
    public class HomeController : Controller
    {
        IHomeService _svc;
        public HomeController(IHomeService homeService)
        {
            this._svc = homeService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}