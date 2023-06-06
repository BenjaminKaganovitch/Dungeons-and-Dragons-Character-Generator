using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.Services;

public interface IDataService
{
	public Class GetClassById(int id);
	public IEnumerable<Spell> GetSpellsBySchool(string magicSchool);
	public IEnumerable<Spell> GetSpellsByClass(string className);
}
