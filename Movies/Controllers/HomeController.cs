using Microsoft.Extensions.Caching.Memory;
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
        
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]
        public ActionResult Netflix()
        {   
            
            return View();
        }

        public ActionResult Movies()
        {
            throw new Exception();

        }

        public ActionResult Customers()
        {
            

            return View();
        }
    }
}