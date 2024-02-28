using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Vendor")]
	public class Vendor
	{
		[Key, Required, Column("Vendor_Id")]
		public string VendorId { get; set; }
		[Required, Column("Vendor_Name")]
		public string VendorName { get; set;}
	}
}
