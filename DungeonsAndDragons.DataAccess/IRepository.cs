using DungeonsAndDragons.Domain;

namespace DungeonsAndDragons.DataAccess;

public interface IRepository
{
    public IEnumerable<Background> GetBackgrounds();
    public IEnumerable<Lineage> GetLineages();
    public IEnumerable<Class> GetClasses();
    public IEnumerable<Spell> GetSpells();
    public IEnumerable<Feat> GetFeats();
    
    public void CreateSpell(Spell spell, IEnumerable<Class> classes);
    public void CreateFeat(Feat feat);
    public void CreateBackground(Background background);

    public int GetStatRoll();
}