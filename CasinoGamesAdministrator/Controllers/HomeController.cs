using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CasinoGamesAdministrator.Database;

namespace CasinoGamesAdministrator.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

	

		public ActionResult CheckLogin(string username, string password)
		{
			if (DatabaseManage.Login(username, password) == true)
			{
				return RedirectToAction("Index", "Admin");
			}
			else if (DatabaseManage.Login(username, password) == false)
			{
				return View("Login");
			}
			else return View("Login");
		}

		public ActionResult Login()
		{
			return View();
		}
	}
}