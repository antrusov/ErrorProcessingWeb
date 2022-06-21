namespace ErrorProcessingWeb.Models.VM.REST;

public class StoryVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<HeroListItemVM>? Heroes { get; set; }
}