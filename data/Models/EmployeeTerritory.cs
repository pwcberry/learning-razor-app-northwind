namespace RazorApp.Data.Models;

public partial class EmployeeTerritory
{
    public string Id { get; set; } = null!;

    public int EmployeeId { get; set; }

    public string? TerritoryId { get; set; }
}
