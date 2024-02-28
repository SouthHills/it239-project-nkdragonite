using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class EditableDatabase
{

    [Inject]
    private AppDbContext DbContext { get; set; }
}