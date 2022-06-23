namespace ErrorProcessingWeb.Models.VM.REST;

public class HeroWithExtrasVM
{
    public int Id { get; set; }
    public string? HeroName { get; set; }
    public string? CivilName { get; set; }
    public DateTime? Birth { get; set; }
    public DateTime? Death { get; set; }
    public IEnumerable<HeroPowerVM>? Powers { get; set; }
    public IEnumerable<HeroStoryVM>? Stories { get; set; }
}