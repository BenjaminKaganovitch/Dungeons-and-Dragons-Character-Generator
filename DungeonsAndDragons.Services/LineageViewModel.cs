using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.Services;

public class LineageViewModel
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string[] FeatureNames { get; set; }
    public string[] FeatureDescription { get; set; }
    public Stat[] Stats { get; set; }
    public int[] StatBoosts { get; set; }
}