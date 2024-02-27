using System.Security.Cryptography;
using System.Text;
using BlazorApp1.Components.Pages.Classes;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages
{
	public partial class Home
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public const string PEPPER = "wPg,r;";
		[Inject]
		private AppDbContext DbContext { get; set; }
		public static string HashPwd(string password, string salt)
		{
			SHA384 sha384 = SHA384.Create();
			byte[] pwdBytes = Encoding.UTF8.GetBytes(password + salt + PEPPER);
			byte[] hashedPwdBytes = sha384.ComputeHash(pwdBytes);
			return Convert.ToBase64String(hashedPwdBytes);
		}
		public string LogIn()
		{
			foreach(Employee emp in DbContext.Employees)
			{
				if(emp.FName + " " + emp.LName == Username)
				{
					if(emp.Password == HashPwd(Password, emp.Salt))
					{
						//Send to Database page
					}
					else
					{
						return "incorrect";
					}
				}
			}
			return "no user";
		}
	}
}
