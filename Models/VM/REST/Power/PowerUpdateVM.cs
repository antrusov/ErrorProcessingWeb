using ErrorProcessingWeb.Models.Enums;

namespace ErrorProcessingWeb.Models.VM.REST;

public class PowerUpdateVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? Distance { get; set; }
    public double? Radius { get; set; }
    public PowerRank Rank { get; set; }
}