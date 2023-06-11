namespace DungeonsAndDragons.Services;

public class BackgroundCreatingModel
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string[] FeatureNames { get; set; }
    public string[] FeatureDescriptions { get; set; }
}