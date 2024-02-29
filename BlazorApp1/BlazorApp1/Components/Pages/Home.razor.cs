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
		public Employee Employee { get; set; }
		[Inject]
		private AppDbContext DbContext { get; set; }
		public string TestString { get; set; }
		public static string HashPwd(string password, string salt)
		{
			SHA384 sha384 = SHA384.Create();
			byte[] pwdBytes = Encoding.UTF8.GetBytes(password + salt + PEPPER);
			byte[] hashedPwdBytes = sha384.ComputeHash(pwdBytes);
			return Convert.ToBase64String(hashedPwdBytes);
		}
		public string LogIn()
		{
			Console.WriteLine("LogIn() called");
			foreach(Employee emp in DbContext.Employees)
			{
				if(emp.EmployeeId == Username)
				{
					if(emp.Password == HashPwd(Password, emp.Salt))
					{
						Employee = emp;
						TestString = "correct";
						return "correct";
					}
					else
					{
                        TestString = "incorrect";
                        return "incorrect";
					}
				}
			}
            TestString = "no user";
            return "no user";
		}
	}
}
