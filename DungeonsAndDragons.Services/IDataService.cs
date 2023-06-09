using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.Services;

public interface IDataService
{
	public static readonly string[] MagicSchools;
	public static readonly Stat[] Stats;
	public static readonly string[] SkillNames;
	public static readonly Dictionary<int, int> ProficiencyBonuses;
	public static readonly Dictionary<int, int> ScoreModifiers;
	public Class GetClassById(int id);
	public Background GetBackgroundById(int id);
	public Feat GetFeatById(int id);
	public Lineage GetLineageById(int id);
	public Spell GetSpellById(int id);
	public IEnumerable<Spell> GetSpellsByClass(string className);
	public IEnumerable<Class> GetCastingClasses();
	public IEnumerable<Background> GetHomebrewBackgrounds();
	public IEnumerable<Spell> GetHomebrewSpells();
	public IEnumerable<Feat> GetHomebrewFeats();
	public IEnumerable<Background> GetUnapprovedHomebrewBackgrounds();
	public IEnumerable<Spell> GetUnapprovedHomebrewSpells();
	public IEnumerable<Feat> GetUnapprovedHomebrewFeats();
	public IEnumerable<Background> GetApprovedHomebrewBackgrounds();
	public IEnumerable<Spell> GetApprovedHomebrewSpells();
	public IEnumerable<Feat> GetApprovedHomebrewFeats();
	public void CreateHomebrewSpell(Spell spell);
	public void CreateHomebrewFeat(Feat feat);
	public void CreateHomebrewBackground(BackgroundViewModel model);
}
