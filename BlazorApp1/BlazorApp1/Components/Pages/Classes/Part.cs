using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Components.Pages.Classes
{
    [Table("Parts")]
    public class Part
    {
        [Key, Required, Column("Part_Id")]
        public int Id { get; set; }
		
        [Column("Part_Name")]
        public string Name { get; set; }
	
        [Column("Vendor_Id")]
        public string VendorID { get; set; }
		
        [Column("Part_Quantity")]
        public string Quantity { get; set; }
		
        [Column("Part_Cost")]
        public decimal Cost { get; set; }
		
        [Column("Location_Id")]
        public string LocationID { get; set; }
    
    }
}