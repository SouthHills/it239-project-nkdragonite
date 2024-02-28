using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
	[Table("Locations")]
	public class Location
	{
		[Key, Required, Column("Location_Id")]
		public string LocationID { get; set; }
		[Required, Column("Location_Name")]
		public string LocationName { get; set; }
	}
}
