using CasinoGamesAdministrator.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace CasinoGamesAdministrator.Database
{
	public class DatabaseManage
	{
		static SqlConnection con = new SqlConnection("Data Source=DESKTOP-38T55SN;Initial Catalog=database;Integrated Security=False;User ID=sa;Password=784512tyghvB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

		

		static public bool Login(string userName, string password)
		{
			bool correctLogin = false;
			string query = "SELECT COUNT(*) FROM Users WHERE UserName='" + userName + "' AND PasswordHash ='" + password + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				correctLogin = true;
			}
			else correctLogin = false;

			return correctLogin;

		}

		static public List<User> GetAllUsers()
		{
			List<User> users = new List<User>();

			string query = "SELECT * FROM Users";



			con.Open();

			SqlCommand cmd = new SqlCommand(query, con);
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					string name = reader.GetString(1);
					DateTime birthdate = reader.GetDateTime(2);
					string country = reader.GetString(3);
					bool verified = reader.GetBoolean(4);
					bool active = reader.GetBoolean(5);
					decimal balance = reader.GetDecimal(6);
					string proof = reader.GetString(7);
					string email = reader.GetString(8);
					string phonenumber = reader.GetString(10);
					string username = reader.GetString(11);
					string role = reader.GetString(12);

					byte[] imageBytes = Convert.FromBase64String(proof);
					MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
					ms.Write(imageBytes, 0, imageBytes.Length);
					Image image = Image.FromStream(ms, true);

					User user = new User()
					{
						Name = name,
						BirthDate = birthdate,
						Country = country,
						Verified = verified,
						Active = active,
						Balance = balance,
						Proof = proof,
						Email = email,
						PhoneNumber = phonenumber,
						UserName = username,
						Role = role
					};
					
					users.Add(user);
				}
			}
			con.Close();

			return users;
		}
	}
}