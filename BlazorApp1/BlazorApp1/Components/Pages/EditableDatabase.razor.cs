using BlazorApp1.Components.Pages.Classes;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class EditableDatabase : ComponentBase
{
    [Inject]
    private AppDbContext DbContext { get; set; }
   
    
    Part newPart = new();

    private void SaveChanges()
    {
        newPart.Id = DbContext.Parts.Max(p => p.Id) + 1;
        DbContext.Parts.Add(newPart);
        DbContext.SaveChanges();
        newPart = new Part();
    }
}