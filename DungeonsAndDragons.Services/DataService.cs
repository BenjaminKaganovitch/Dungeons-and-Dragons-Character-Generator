using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

    public static readonly Dictionary<int, int> ProficiencyBonuses = new()
    {
        {1, 2}, {2, 2}, {3, 2}, {4, 2},
        {5, 3}, {6, 3}, {7, 3}, {8, 3},
        {9, 4}, {10, 4}, {11, 4}, {12, 4},
        {13, 5}, {14, 5}, {15, 5}, {16, 5},
        {17, 6}, {18, 6}, {19, 6}, {20, 6}
    };
    
    public static readonly Dictionary<int, int> ScoreModifiers = new()
    {
        {1, -5}, {2, -4}, {3, -4}, {4, -3},
        {5, -3}, {6, -2}, {7, -2}, {8, -1},
        {9, -1}, {10, 0}, {11, 0}, {12, 1},
        {13, 1}, {14, 2}, {15, 2}, {16, 3},
        {17, 3}, {18, 4}, {19, 4}, {20, 5}
    };
    
    public Class GetClassById(int id)
    {
        return _context.Classes.
            SingleOrDefault(c => c.Id == id)!;
    }

    public Background GetBackgroundById(int id)
    {
        return _context.Backgrounds.
            Include(background=>background.Creator).
            Include(background=>background.Features).
            SingleOrDefault(background => background.Id == id)!;
    }

    public Feat GetFeatById(int id)
    {
        return _context.Feats.
            SingleOrDefault(feat => feat.Id == id)!;
    }

    public Lineage GetLineageById(int id)
    {
        return _context.Lineages.
            Include(l=>l.Creator).
            Include(l => l.Sublineages).ThenInclude(s=>s.Features).
            Include(l => l.Sublineages).ThenInclude(s => s.Spells).
            Include(l => l.Sublineages).ThenInclude(s => s.StatBoosts).
            Include(l => l.Sublineages).ThenInclude(s => s.Creator).
            Include(l => l.StatBoosts).
            Include(l => l.Features).
            SingleOrDefault(lineage => lineage.Id == id)!;
    }

    public Spell GetSpellById(int id)
    {
        return _context.Spells.
            Include(spell => spell.Creator).
            SingleOrDefault(spell => spell.Id == id)!;
    }

    public IEnumerable<Spell> GetSpellsBySchool(string magicSchool)
    {
        return _context.Spells.
            Include(spell => spell.Creator).
            Where(s => s.MagicSchool == magicSchool);
    }

    public IEnumerable<Spell> GetSpellsByClass(string className)
    {
        return _context.Classes.Include(c => c.Spells).
            SingleOrDefault(c => c.Name == className)!.Spells;
    }

    public IEnumerable<Class> GetCastingClasses()
    {
        return _context.Classes.Where(c => c.CanCast);
    }

    public IEnumerable<Background> GetHomebrewBackgrounds()
    {
        return _context.Backgrounds.
            Where(background => background.Source == "Housebrew" || background.Source == "Homebrew");
    }

    public IEnumerable<Spell> GetHomebrewSpells()
    {
        return _context.Spells.
            Include(spell => spell.Creator).
            Where(spell => spell.Source == "Housebrew" || spell.Source == "Homebrew");
    }

    public IEnumerable<Feat> GetHomebrewFeats()
    {
        return _context.Feats.
            Where(feat => feat.Source == "Housebrew" || feat.Source == "Homebrew");
    }

    public IEnumerable<Background> GetOfficialBackgrounds()
    {
        return _context.Backgrounds.
            Where(background => background.Source != "Housebrew" && background.Source != "Homebrew");;
    }

    public IEnumerable<Spell> GetOfficialSpells()
    {
        return _context.Spells.
            Where(spell => spell.Source != "Housebrew" && spell.Source != "Homebrew");    }

    public IEnumerable<Feat> GetOfficialFeats()
    {
        return _context.Feats.
            Where(feat => feat.Source != "Housebrew" && feat.Source != "Homebrew");    }

    public IEnumerable<Background> GetUnapprovedHomebrewBackgrounds()
    {
        return _context.Backgrounds.
            Where(background => background.Source == "Housebrew");
    }

    public IEnumerable<Spell> GetUnapprovedHomebrewSpells()
    {
        return _context.Spells.
            Include(spell => spell.Creator).
            Where(spell => spell.Source == "Housebrew");
    }

    public IEnumerable<Feat> GetUnapprovedHomebrewFeats()
    {
        return _context.Feats.
            Where(feat => feat.Source == "Housebrew");    }

    public IEnumerable<Background> GetApprovedHomebrewBackgrounds()
    {
        return _context.Backgrounds.
            Where(background => background.Source == "Homebrew");    }

    public IEnumerable<Spell> GetApprovedHomebrewSpells()
    {
        return _context.Spells.
            Include(spell => spell.Creator).
            Where(spell => spell.Source == "Homebrew");    
    }

    public IEnumerable<Feat> GetApprovedHomebrewFeats()
    {
        return _context.Feats.
            Where(feat => feat.Source == "Homebrew");
    }

    public IEnumerable<Spell> GetSpellsByLevel(SpellType type)
    {
        return _context.Spells.Where(s => s.SpellType == type);
    }
    
    public void CreateHomebrewSpell(SpellCreatingModel model, string creatorId, string components)
    {
        Spell finishedSpell = new()
        {
            Name = model.Name,
            Description = model.Description,
            Range = model.Range,
            Duration = model.Duration,
            Components = components,
            CreatorId = creatorId,
            MagicSchool = model.MagicSchool,
            SpellType = model.SpellType,
            CastingTime = model.CastingTime,
            Source = model.Source
        };

        foreach (int id in model.ClassIds)
        {
            GetClassById(id).Spells.Add(finishedSpell);
        }
        
        _context.Spells.Add(finishedSpell);
        _context.SaveChanges();
    }

    public void CreateHomebrewFeat(Feat feat)
    {
        feat.Source = "Housebrew";
        
        _context.Feats.Add(feat);
        _context.SaveChanges();
    }

    public void CreateHomebrewBackground(BackgroundViewModel model)
    {
        Background background = new()
        {
            Name = model.Name,
            Description = model.Description,
            Source = "Housebrew"
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

        _context.Backgrounds.Add(background);
        _context.SaveChanges();
    }
}