using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Employee")]
	public class Employee
	{

		[Key, Required, Column("EMPLOYEE_ID")]
		public uint EmployeeId { get; set; }
		[Required, Column("EMPLOYEE_FNAME")]
		public string FName { get; set; }
		[Required, Column("EMPLOYEE_LNAME")]
		public string LName { get; set; }
		[Required, Column("EMPLOYEE_PERMISSION")]
		public string Permission { get; set; }
		[Required, Column("LOCATION_ID")]
		public Location Location { get; set; }
		[Required, Column("EMPLOYEE_PASSWORD")]
		public string Password { get; set; }
		[Required, Column("EMPLOYEE_SALT")]
		public string Salt { get; set; }

	}
}
