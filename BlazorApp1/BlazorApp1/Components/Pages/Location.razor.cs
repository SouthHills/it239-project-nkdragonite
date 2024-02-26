using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages
{
	public partial class Location
	{
		[Inject]
		private AppDbContext DbContext { get; set; }
	}
}
