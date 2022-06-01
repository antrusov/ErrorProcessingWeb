namespace ErrorProcessingWeb.Models.Entity;

public class CreateHeroEntity
{
    public string HeroName { get; set; }
    public string CivilName { get; set; }
    public DateTime? Birth { get; set; }
    public DateTime? Death { get; set; }
}