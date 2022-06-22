namespace ErrorProcessingWeb.Models.Dto;

public class HeroWithExtrasDto
{
    public int Id { get; set; }
    public string? HeroName { get; set; }
    public string? CivilName { get; set; }
    public DateTime? Birth { get; set; }
    public DateTime? Death { get; set; }
    public IEnumerable<PowerDto>? Powers { get; set; }
    public IEnumerable<StoryDto>? Stories { get; set; }
}