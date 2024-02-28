using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Parts")]
	public class Part
	{
		[Key, Required, Column("Part_Id")]
		public string Id { get; set; }
		//[Required, Column("Part_Name")]
		//public string Name { get; set; }
		//[Required, Column("Part_Desc")]
		//public string Description { get; set; }
		[Required, Column("Vendor_Id")]
		public string VendorID { get; set; }
		[Required, Column("Part_Quantity")]
		public int Quantity { get; set; }
		[Required, Column("Part_Cost")]
		public decimal Cost { get; set; }
		[Required, Column("Location_Id")]
		public string LocationID { get; set; }
	}
}
