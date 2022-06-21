namespace ErrorProcessingWeb.Models.VM.REST;

public class StoryStatisticListItemVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int HeroCount { get; set; }
    public int PowerCount { get; set; }
}