using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CasinoGamesAdministrator.Database;

namespace CasinoGamesAdministrator.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult AccountList()
		{
			return View(DatabaseManage.GetAllUsers());
		}
    }
}