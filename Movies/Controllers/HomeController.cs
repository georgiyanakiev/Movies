using Movies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        
        [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")]
        public ActionResult Netflix()
        {
           
            return View();
        }

        public ActionResult Movies()
        {
           

            return View();
        }

        public ActionResult Customers()
        {
            

            return View();
        }
    }
}