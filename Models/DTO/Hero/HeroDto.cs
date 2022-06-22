namespace ErrorProcessingWeb.Models.Dto;

public class HeroDto
{
    public int Id { get; set; }
    public string? HeroName { get; set; }
    public string? CivilName { get; set; }
    public DateTime? Birth { get; set; }
    public DateTime? Death { get; set; }
}
