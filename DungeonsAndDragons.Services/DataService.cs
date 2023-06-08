using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Domain;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.Services;

public class DataService : IDataService
{
    private ApplicationDbContext _context;

    public DataService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public static readonly string[] MagicSchools =
    {
        "Evocation",
        "Divination",
        "Abjuration",
        "Transmutation",
        "Conjuration",
        "Illusion",
        "Enchantment",
        "Necromancy"
    };

    public static readonly Stat[] Stats =
    {
        Stat.Strength,
        Stat.Dexterity,
        Stat.Constitution,
        Stat.Wisdom,
        Stat.Intelligence,
        Stat.Charisma
    };

    public static readonly string[] SkillNames =
    {
        "Acrobatics",
        "Animal Handling",
        "Arcana",
        "Athletics",
        "Deception",
        "History",
        "Insight",
        "Intimidation",
        "Investigation",
        "Medicine",
        "Nature",
        "Perception",
        "Performance",
        "Persuasion",
        "Religion",
        "Sleight of Hand",
        "Stealth",
        "Survival"
    };
    
    
    
    public Class GetClassById(int id)
    {
        return _context.Classes.SingleOrDefault(c => c.Id == id)!;
    }

    public IEnumerable<Spell> GetSpellsBySchool(string magicSchool)
    {
        return _context.Spells.Where(s => s.MagicSchool == magicSchool);
    }

    public IEnumerable<Spell> GetSpellsByClass(string className)
    {
        return _context.Classes.Include(c => c.Spells).
            SingleOrDefault(c => c.Name == className)!.Spells;
    }

    public IEnumerable<Spell> GetSpellsByLevel(SpellType type)
    {
        return _context.Spells.Where(s => s.SpellType == type);
    }
    
    public void CreateHomebrewSpell(Spell spell)
    {
        _context.HomebrewSpells.Add(spell);
        _context.SaveChanges();
    }

    public void CreateHomebrewFeat(Feat feat)
    {
        _context.HomebrewFeats.Add(feat);
        _context.SaveChanges();
    }

    public void CreateHomebrewBackground(BackgroundViewModel model)
    {
        Background background = new()
        {
            Name = model.Name,
            Description = model.Description
        };

        for (int i = 0; i < model.FeatureNames.Length; i++)
        {
            Feature feature = new()
            {
                Name = model.FeatureNames[i], 
                Description = model.FeatureDescriptions[i]
            };
            
            background.Features.Add(feature);
        }

        _context.HomebrewBackgrounds.Add(background);
        _context.SaveChanges();
    }
}