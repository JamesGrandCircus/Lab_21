using System.Web.Mvc;
using WebApplication3.Models;

// James - I'll check this out in person
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
			ViewBag.Message = "Please register here";
			return View();
		}

		// James - getting mixed with dotnet core?
		[HttpPost]
		public ActionResult SummaryPage(UserRegistrationModel userRegistration)
		{


			return View(userRegistration);
		}
	}
}