using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.Services;

public interface IDataService
{
	public Class GetClassById(int id);
	public IEnumerable<Spell> GetSpellsBySchool(string magicSchool);
	public IEnumerable<Spell> GetSpellsByClass(string className);

	public Spell CreateHomebrewSpell(Spell spell);

	public Feat CreateHomebrewFeat(Feat feat);

	public Background CreateHomebrewBackground(BackgroundViewModel model);

	public Lineage CreateHomebrewLineage(Lineage lineage);

	public Sublineage CreateHomebrewSublineage(Sublineage sublineage);
}
