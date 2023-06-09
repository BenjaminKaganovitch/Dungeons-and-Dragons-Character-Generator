using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonsAndDragons.Services;

public class DataService : IDataService
{
    private IRepository _repository;

    public DataService(IRepository repository)
    {
        _repository = repository;
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
        return _repository.GetClasses().
            SingleOrDefault(c => c.Id == id)!;
    }

    public Background GetBackgroundById(int id)
    {
        return _repository.GetBackgrounds().
            SingleOrDefault(background => background.Id == id)!;
    }

    public Feat GetFeatById(int id)
    {
        return _repository.GetFeats().
            SingleOrDefault(feat => feat.Id == id)!;
    }

    public Lineage GetLineageById(int id)
    {
        return _repository.GetLineages().
            SingleOrDefault(lineage => lineage.Id == id)!;
    }

    public Spell GetSpellById(int id)
    {
        return _repository.GetSpells().
            SingleOrDefault(spell => spell.Id == id)!;
    }

    public IEnumerable<Spell> GetSpellsBySchool(string magicSchool)
    {
        return _repository.GetSpells().
            Where(s => s.MagicSchool == magicSchool);
    }

    public IEnumerable<Spell> GetSpellsByClass(string className)
    {
        return _repository.GetClasses().
            SingleOrDefault(c => c.Name == className)!.Spells;
    }

    public IEnumerable<Class> GetCastingClasses()
    {
        return _repository.GetClasses().
            Where(c => c.CanCast);
    }

    public IEnumerable<Background> GetHomebrewBackgrounds()
    {
        return _repository.GetBackgrounds().
            Where(background => background.Source == "Housebrew" || background.Source == "Homebrew");
    }

    public IEnumerable<Spell> GetHomebrewSpells()
    {
        return _repository.GetSpells().
            Where(spell => spell.Source == "Housebrew" || spell.Source == "Homebrew");
    }

    public IEnumerable<Feat> GetHomebrewFeats()
    {
        return _repository.GetFeats().
            Where(feat => feat.Source == "Housebrew" || feat.Source == "Homebrew");
    }

    public IEnumerable<Background> GetOfficialBackgrounds()
    {
        return _repository.GetBackgrounds().
            Where(background => background.Source != "Housebrew" && background.Source != "Homebrew");;
    }

    public IEnumerable<Spell> GetOfficialSpells()
    {
        return _repository.GetSpells().
            Where(spell => spell.Source != "Housebrew" && spell.Source != "Homebrew");    }

    public IEnumerable<Feat> GetOfficialFeats()
    {
        return _repository.GetFeats().
            Where(feat => feat.Source != "Housebrew" && feat.Source != "Homebrew");    }

    public IEnumerable<Background> GetUnapprovedHomebrewBackgrounds()
    {
        return GetHomebrewBackgrounds().
            Where(background => background.Source == "Housebrew");
    }

    public IEnumerable<Spell> GetUnapprovedHomebrewSpells()
    {
        return GetHomebrewSpells().
            Where(spell => spell.Source == "Housebrew");
    }

    public IEnumerable<Feat> GetUnapprovedHomebrewFeats()
    {
        return GetHomebrewFeats().
            Where(feat => feat.Source == "Housebrew");    }

    public IEnumerable<Background> GetApprovedHomebrewBackgrounds()
    {
        return GetHomebrewBackgrounds().
            Where(background => background.Source == "Homebrew");    }

    public IEnumerable<Spell> GetApprovedHomebrewSpells()
    {
        return GetHomebrewSpells().
            Where(spell => spell.Source == "Homebrew");    
    }

    public IEnumerable<Feat> GetApprovedHomebrewFeats()
    {
        return GetHomebrewFeats().
            Where(feat => feat.Source == "Homebrew");
    }

    public IEnumerable<Spell> GetSpellsByType(SpellType type)
    {
        return _repository.GetSpells().
            Where(s => s.SpellType == type);
    }
    
    public Spell CreateHomebrewSpell(SpellCreatingModel model, string creatorId, string components)
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

        var classes = _repository.GetClasses().
            Where(c => model.Classes.Contains($"{c.Id}"));

        _repository.CreateSpell(finishedSpell, classes);

        return finishedSpell;
    }

    public Feat CreateHomebrewFeat(FeatCreatingModel model, string creatorId)
    {
        Feat feat = new()
        {
            Source = "Housebrew",
            Name = model.Name,
            Description = model.Description,
            CreatorId = creatorId
        };
        
        _repository.CreateFeat(feat);

        return feat;
    }

    public Background CreateHomebrewBackground(BackgroundCreatingModel model, string creatorId)
    {
        Background background = new()
        {
            Name = model.Name,
            Description = model.Description,
            Source = "Housebrew",
            CreatorId = creatorId
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

        _repository.CreateBackground(background);
        return background;
    }
}