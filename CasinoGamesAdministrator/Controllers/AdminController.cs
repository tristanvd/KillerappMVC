using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CasinoGamesAdministrator.Classes;
using CasinoGamesAdministrator.Database;

namespace CasinoGamesAdministrator.Controllers
{
    public class AdminController : Controller
    {
		[Authorize(Roles = "Admin")]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult AccountList()
		{
			return View(DatabaseManage.GetAllUsers());
		}

		public ActionResult ProofCheck()
		{
			return View(DatabaseManage.GetAllUsers());
		}

		public ActionResult VerifyUser(User user)
		{
			return View(user);
		}
    }
}