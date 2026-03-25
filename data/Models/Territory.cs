namespace RazorApp.Data.Models;

public partial class Territory
{
    public string Id { get; set; } = null!;

    public string? TerritoryDescription { get; set; }

    public int RegionId { get; set; }
}
