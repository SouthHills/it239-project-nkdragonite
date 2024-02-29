using BlazorApp1.Components.Pages.Classes;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class EditableDatabase
{

    [Inject]
    private AppDbContext DbContext { get; set; }
    /*public Part newPart = new();
    public string NewName { get; set; }
    public string NewQuantity { get; set; }
    public decimal NewCost { get; set; }
    public string NewVendor { get; set; }
    public string NewLocation { get; set; }
    protected override void OnInitialized()
    {
        newPart.Id = DbContext.Parts.Max(p => p.Id) + 1;
    }
    public async void SaveChanges()
    {
        newPart.Name = NewName;
        newPart.Quantity = NewQuantity;
        newPart.Cost = NewCost;
        newPart.VendorID = NewVendor;
        newPart.LocationID = NewLocation;
        DbContext.Parts.Add(newPart);
        await DbContext.SaveChangesAsync();
    }*/
}