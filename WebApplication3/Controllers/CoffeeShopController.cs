using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CoffeeShopController : Controller
    {

        // GET: CoffeeShop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserRegistration()
        {
            ViewBag.Message= "Please register here";
            return View();
        }
       [HttpPost]
        public ActionResult SummaryPage(UserRegistrationModel userRegistration)
        {
            
           
            return View(userRegistration);
        }
    }
}