using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages
{
	public partial class Database
	{ 
		[Inject]
		private AppDbContext DbContext { get; set; }
	}
}
