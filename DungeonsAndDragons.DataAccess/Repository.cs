using DungeonsAndDragons.Domain;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.DataAccess;

public class Repository : IRepository
{
    private ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Class> GetClasses()
    {
        return _context.Classes
            .Include(c=>c.Features)
            .Include(c=>c.Spells)
            .Include(c=>c.Subclasses).ThenInclude(s=>s.Spells)
            .Include(c => c.Subclasses).ThenInclude(s => s.Features)
            .Include(c => c.Subclasses).ThenInclude(s => s.Creator);
    }
    
    
    public IEnumerable<Background> GetBackgrounds()
    {
        return _context.Backgrounds
            .Include(b=>b.Creator)
            .Include(b=>b.Features);
    }

    public IEnumerable<Lineage> GetLineages()
    {
        return _context.Lineages.Include(l => l.Creator)
            .Include(l => l.Sublineages).ThenInclude(s => s.Features)
            .Include(l => l.Sublineages).ThenInclude(s => s.Spells)
            .Include(l => l.Sublineages).ThenInclude(s => s.StatBoosts)
            .Include(l => l.Sublineages).ThenInclude(s => s.Creator)
            .Include(l => l.StatBoosts)
            .Include(l => l.Features);
    }


    public IEnumerable<Spell> GetSpells()
    {
        return _context.Spells.
            Include(spell => spell.Creator);
    }

    public IEnumerable<Feat> GetFeats()
    {
        return _context.Feats.
            Include(f => f.Creator);
    }

    public void CreateSpell(Spell spell, IEnumerable<Class> classes)
    {
        _context.Spells.Add(spell);
        
        foreach (Class c in classes)
        {
            c.Spells.Add(spell);
            _context.Classes.Update(c);
        }

        _context.SaveChanges();
    }

    public void CreateFeat(Feat feat)
    {
        _context.Feats.Add(feat);
        _context.SaveChanges();
    }

    public void CreateBackground(Background background)
    {
        _context.Backgrounds.Add(background);
        _context.SaveChanges();
    }

    //Roll 4d6 and drop the lowest roll
    public int GetStatRoll()
    {
        Random random = new();
        List<int> rolls = new();
        
        for (int i = 0; i < 4; i++)
        {
            int roll = random.Next(1, 7);
            rolls.Add(roll);
        }

        return rolls.OrderByDescending(i => i).Take(3).Sum();

    }
}