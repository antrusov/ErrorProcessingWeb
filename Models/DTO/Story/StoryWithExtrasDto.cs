namespace ErrorProcessingWeb.Models.Dto;

public class StoryWithExtrasDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<HeroDto>? Heroes { get; set; }
    public IEnumerable<PowerWithHeroIdDto>? Powers { get; set; }
}
