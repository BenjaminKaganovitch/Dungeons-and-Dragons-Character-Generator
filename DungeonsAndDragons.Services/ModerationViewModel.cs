using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.Services;

public class ModerationViewModel
{
    public IEnumerable<Spell> HomebrewSpells { get; }
    public IEnumerable<Feat> HomebrewFeats { get; }
    public IEnumerable<Background> HomebrewBackgrounds { get; }

    public ModerationViewModel(DataService service)
    {
        HomebrewSpells = service.GetHomebrewSpells();
        HomebrewFeats = service.GetHomebrewFeats();
        HomebrewBackgrounds = service.GetHomebrewBackgrounds();
    }
}