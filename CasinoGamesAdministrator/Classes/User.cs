using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasinoGamesAdministrator.Classes
{
	public class User
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public string Country { get; set; }
		public bool Verified { get; set; }
		public bool Active { get; set; }
		public decimal Balance { get; set; }
		public string Proof { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string UserName { get; set; }
	}
}