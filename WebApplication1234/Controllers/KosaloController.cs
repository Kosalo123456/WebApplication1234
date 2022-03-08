using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1234.Controllers
{
    public class KosaloController : Controller
    {
        // GET: Kosalo
        public ActionResult Index()
        {


            ViewBag Lokacija="Međimursko Veleučilište u Čakovcu"
            return View();
        }
    }
}