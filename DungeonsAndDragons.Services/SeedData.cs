using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.Domain;
using DungeonsAndDragons.DataAccess;

namespace DungeonsAndDragons.Services
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                SeedDB(context);
            }
        }

        public static void SeedDB(ApplicationDbContext context)
        {

            if (context.Feats.Count() < 1 && context.Spells.Count() < 1)
            {
                #region Spells
                //All you need is Fireball...
                Spell fireballCantrip = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.Cantrip,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballFirstLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.FirstLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballSecondLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.SecondLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireball = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.ThirdLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballFourthLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.FourthLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballFifthLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.FifthLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballSixthLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.SixthLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballSeventhLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.SeventhLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballEighthLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.EighthLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                Spell fireballNinthLevel = new()
                {
                    Name = "Fireball",
                    Source = "Player's Handbook",
                    SpellType = SpellType.NinthLevel,
                    MagicSchool = "Evocation",
                    Range = "150 feet",
                    CastingTime = "1 action",
                    Duration = "Instantaneous",
                    Components = "Verbal, Somatic, Material (a tiny ball of bat guano and sulfur",
                    Description = "A bright streak flashes from your pointing finger to a point you choose within range " +
                                  "then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot " +
                                  "radius must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed " +
                                  "save, or half as much damage on a successful one. The fire spreads around corners. It" +
                                  " ignites flammable objects in the area that aren’t being worn or carried.\n \n " +
                                  "At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, " +
                                  "the damage increases by 1d6 for each slot level above 3rd."
                };
                
                #endregion

                #region Feats

                Feat sentinel = new()
                {
                    Name = "Sentinel",
                    Source = "Player's Handbook",
                    Description = "You have mastered techniques to take advantage of every drop in any enemy's guard, " +
                                  "gaining the following benefits.\n" +
                                  "- When you hit a creature with an opportunity attack, the creature's speed becomes 0 " +
                                  "for the rest of the turn.\n" +
                                  "- Creatures provoke opportunity attacks from you even if they take the Disengage " +
                                  "action before leaving your reach.\n"+
                                  "- When a creature makes an attack against a target other than you (and that " +
                                  "target doesn't have this feat), you can " +
                                  "use your reaction to make a melee weapon attack against the attacking creature."
                };

                Feat lucky = new()
                {
                    Name = "Lucky",
                    Source = "Player's Handbook",
                    Description = "You have inexplicable luck that seems to kick in at just the right moment.\n"+

                    "You have 3 luck points. Whenever you make an attack roll, an ability check, or a saving " +
                    "throw, you can spend one luck point to roll an additional d20. You can choose to spend " +
                    "one of your luck points after you roll the die, but before the outcome is determined. " +
                    "You choose which of the d20s is used for the attack roll, ability check, or saving throw.\n" +
                    "You can also spend one luck point when an attack roll is made against you. Roll a d20 and " +
                    "then choose whether the attack uses the attacker's roll or yours.\n" +
                    "If more than one creature spends a luck point to influence the outcome of a roll, the " +
                    "points cancel each other out; no additional dice are rolled.\n" +
                    "You regain your expended luck points when you finish a long rest."
                };

                Feat alert = new()
                {
                    Name = "Alert",
                    Source = "Player's Handbook",
                    Description = "Always on the lookout for danger, you gain the following benefits:\n" +
                                  "You can't be surprised while you are conscious.\n" +
                                  "You gain a +5 bonus to initiative.\n" +
                                  "Other creatures don't gain advantage on attack rolls against you " +
                                  "as a result of being unseen by you."
                };

                #endregion

                //To be added later
                #region Lineages

                Lineage human = new()
                {
                    Name = "Human",
                    Source = "Basic Rules",
                    Description =
                        "Humans are the most common and widespread race in many fantasy settings. They come in " +
                        "various ethnicities and cultures, displaying a wide range of appearances, beliefs, and" +
                        " abilities. Humans are adaptable and versatile, capable of excelling in various " +
                        "professions and roles.",
                    Sublineages = new List<Sublineage>()
                    {
                        new()
                        {
                            Name = "Standard Human",
                            Source = "Basic Rules",
                            Description =
                                "Bog-standard humans. While unremarkable in terms of unique features, standard" +
                                " humans have more of a balance in their abilities compared to other lineages.",
                            Size = Size.Medium,
                            MovementSpeed = "30 feet (walking)",
                            StatBoosts = new List<StatBoost>()
                            {
                                new() { Stat = Stat.Strength, Value = 1 },
                                new() { Stat = Stat.Dexterity, Value = 1 },
                                new() { Stat = Stat.Constitution, Value = 1 },
                                new() { Stat = Stat.Intelligence, Value = 1 },
                                new() { Stat = Stat.Wisdom, Value = 1 },
                                new() { Stat = Stat.Charisma, Value = 1 }
                            }
                        },
                        new()
                        {
                            Name = "Variant Human",
                            Source = "Basic Rules",
                            Description = "If your campaign uses the optional feat rules from chapter 5 of the " +
                                          "Player's Handbook, your Dungeon Master might allow these variant " +
                                          "traits, all of which replace the human's Ability Score Increase trait.",
                            Size = Size.Medium,
                            MovementSpeed = "30 feet (walking)",
                            StatBoosts = new List<StatBoost>()
                            {
                                new() { Stat = Stat.Any, Value = 1 },
                                new() { Stat = Stat.Any, Value = 1 }
                            },
                            Features = new List<Feature>()
                            {
                                new()
                                {
                                    Name = "Skills", 
                                    Description = "You gain proficiency with one skill of your choice."
                                },
                                new() { Name = "Feat", Description = "You gain one Feat of your choice." }
                            }

                        }
                    }
                };
                
                Lineage dwarf = new()
                {
                    Name = "Dwarf",
                    Source = "Basic Rules",
                    Description = "Dwarves are a short and stout humanoid race known for their craftsmanship, resilience," +
                                  " and affinity for mining and underground life. They are often associated with " +
                                  "mountains and have a reputation for their love of ale and strong spirits.",
                    StatBoosts = new List<StatBoost>()
                    {
                        new() { Stat = Stat.Constitution, Value = 2 }
                    },
                    Features = new List<Feature>()
                    {
                        new()
                        {
                            Name = "Darkvision",
                            Description = "Accustomed to life underground, you have superior vision in dark and dim " +
                                          "conditions. You can see in dim light within 60 feet of you as if it were " +
                                          "bright light, and in darkness as if it were dim light. You can’t discern " +
                                          "color in darkness, only shades of gray."
                        },
                        new()
                        {
                            Name = "Dwarven Resilience",
                            Description = "You have advantage on saving throws against poison, and you have " +
                                          "resistance against poison damage."
                        },
                        new()
                        {
                            Name = "Dwarven Combat Training",
                            Description = "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer."
                        },
                        new()
                        {
                            Name = "Tool Proficiency",
                            Description = "You gain proficiency with the artisan’s tools of your choice: smith’s tools, " +
                                          "brewer’s supplies, or mason’s tools."
                        },
                        new()
                        {
                            Name = "Stonecunning",
                            Description = "Whenever you make an Intelligence (History) check related to the origin of " +
                                          "stonework, you are considered proficient in the History skill and add double " +
                                          "your proficiency bonus to the check, instead of your normal proficiency bonus."
                        }
                    },
                    Sublineages = new List<Sublineage>()
                    {
                        new()
                        {
                            Name = "Hill Dwarf",
                            Source = "Basic Rules",
                            Size = Size.Medium,
                            MovementSpeed = "25 feet (walking)",
                            Description = "As a hill dwarf, you have keen senses, deep intuition, and remarkable " +
                                          "resilience. The gold dwarves of Faerun in their mighty southern kingdom " +
                                          "are hill dwarves, as are the exiled Neidar and the debased Klar of " +
                                          "Krynn in the Dragonlance setting.",
                            StatBoosts = new List<StatBoost>()
                            {
                                new() { Stat = Stat.Wisdom, Value = 1 }
                            },
                            Features = new List<Feature>()
                            {
                                new()
                                {
                                    Name = "Dwarven Toughness",
                                    Description = "Your hit point maximum increases by 1, and it increases by 1 every " +
                                                  "time you gain a level."
                                }
                            }
                        },
                        new()
                        {
                            Name = "Mountain Dwarf",
                            Source = "Basic Rules",
                            Size = Size.Medium,
                            MovementSpeed = "25 feet (walking)",
                            Description = "As a mountain dwarf, you’re strong and hardy, " +
                                          "accustomed to a difficult life in rugged terrain. You’re " +
                                          "probably on the tall side (for a dwarf), and tend toward " +
                                          "lighter coloration. The shield dwarves of northern " +
                                          "Faerûn, as well as the ruling Hylar clan and the noble " +
                                          "Daewar clan of Dragonlance, are mountain dwarves.",
                            StatBoosts = new List<StatBoost>()
                            {
                                new() { Stat = Stat.Strength, Value = 2 }
                            },
                            Features = new List<Feature>()
                            {
                                new()
                                {
                                    Name = "Dwarven Armor Training",
                                    Description = "You have proficiency with light and medium armor."
                                }
                            }
                        }
                    }
                };

                #endregion

                #region Classes

                Class wizard = new()
                {
                    Name = "Wizard",
                    Source = "Basic Rules",
                    Description = "Wizards are scholarly spellcasters who study and manipulate arcane magic through " +
                                  "rigorous study and research. They possess a vast knowledge of spells and can cast " +
                                  "a wide range of magical effects. Wizards are known for their spellbooks, which " +
                                  "contain their collected arcane knowledge, and they can specialize in specific " +
                                  "schools of magic or become versatile generalists.",
                    HitDieType = DieType.SixSides,
                    SubclassUnlockLevel = 2,
                    Features = new List<Feature>()
                    {
                        #region Spellcasting
                        
                        new()
                        {
                            Name = "Spellcasting",
                            Description = "As a student of arcane magic, you have a spellbook containing spells that " +
                                          "show the first glimmerings of your true power."
                        },
                        new()
                        {
                            Name = "Cantrips",
                            Description = "At 1st level, you know three cantrips of your choice from the wizard spell " +
                                          "list. You learn additional wizard cantrips of your choice at higher levels, " +
                                          "as shown in the Cantrips Known column of the Wizard table."
                        },
                        new()
                        {
                            Name = "Spellbook",
                            Description = "At 1st level, you have a spellbook containing six 1st-level wizard spells " +
                                          "of your choice. Your spellbook is the repository of the wizard spells you " +
                                          "know, except your cantrips, which are fixed in your mind."
                        },
                        new() 
                        {
                            Name = "Preparing and Casting Spells",
                            Description = "The Wizard table shows how many spell slots you have to cast your spells " +
                                          "of 1st level and higher. To cast one of these spells, you must expend a " +
                                          "slot of the spell’s level or higher. You regain all expended spell slots " +
                                          "when you finish a long rest.\nYou prepare the list of wizard spells that " +
                                          "are available for you to cast. To do so, choose a number of wizard spells" +
                                          "from your spellbook equal to your Intelligence modifier + your wizard " +
                                          "level (minimum of one spell). The spells must be of a level for which " +
                                          "you have spell slots. \nFor example, if you’re a 3rd-level wizard, you " +
                                          "have four 1st-level and two 2nd-level spell slots. With an Intelligence " +
                                          "of 16, your list of prepared spells can include six spells of 1st or 2nd " +
                                          "level, in any combination, chosen from your spellbook. If you prepare the " +
                                          "1st-level spell Magic Missile, you can cast it using a 1st-level or a " +
                                          "2nd-level slot. Casting the spell doesn’t remove it from your list " +
                                          "of prepared spells.\nYou can change your list of prepared spells when " +
                                          "you finish a long rest. Preparing a new list of wizard spells requires " +
                                          "time spent studying your spellbook and memorizing the incantations " +
                                          "and gestures you must make to cast the spell: at least 1 minute per " +
                                          "spell level for each spell on your list."
                        },
                        new()
                        {
                            Name = "Spellcasting Ability",
                            Description = "Intelligence is your spellcasting ability for your wizard spells, " +
                                          "since you learn your spells through dedicated study and memorization. " +
                                          "You use your Intelligence whenever a spell refers to your spellcasting " +
                                          "ability. In addition, you use your Intelligence modifier when setting " +
                                          "the saving throw DC for a wizard spell you cast and when making an " +
                                          "attack roll with one. \n" +
                                          "Spell save DC = 8 + your proficiency bonus + your Intelligence modifier\n" +
                                          "Spell attack modifier = your proficiency bonus + your Intelligence modifier"
                        },
                        new()
                        {
                            Name = "Ritual Casting",
                            Description = "You can cast a wizard spell as a ritual if that spell has the ritual tag " +
                                          "and you have the spell in your spellbook. You don’t need to have the " +
                                          "spell prepared."
                        },
                        new()
                        {
                            Name = "Spellcasting Focus",
                            Description = "You can use an arcane focus as a spellcasting focus for your wizard spells."
                        },
                        new()
                        {
                            Name = "Learning Spells of 1st Level and Higher",
                            Description = "Each time you gain a wizard level, you can add two wizard spells of " +
                                          "your choice to your spellbook for free. Each of these spells must be " +
                                          "of a level for which you have spell slots, as shown on the Wizard " +
                                          "table. On your adventures, you might find other spells that you can " +
                                          "add to your spellbook."
                        },

                        #endregion
                        
                        new()
                        {
                            Name = "Arcane Recovery",
                            Description = "You have learned to regain some of your magical energy by studying " +
                                          "your spellbook. Once per day when you finish a short rest, you can " +
                                          "choose expended spell slots to recover. The spell slots can have a " +
                                          "combined level that is equal to or less than half your wizard level" +
                                          " (rounded up), and none of the slots can be 6th level or higher. " +
                                          "\nFor example, if you're a 4th-level wizard, you can recover up to " +
                                          "two levels worth of spell slots. You can recover either a 2nd-level" +
                                          " spell slot or two 1st-level spell slots."
                        },
                        new()
                        {
                            Name = "Arcane Tradition",
                            Description = "When you reach 2nd level, you choose an arcane tradition, shaping " +
                                          "your practice of magic through one of the following schools. Your " +
                                          "choice grants you features at 2nd level and again at 6th, 10th, " +
                                          "and 14th level."
                        },
                        new() 
                        {
                            Name = "Cantrip Formulas (Optional)",
                            Description = "At 3rd level, you have scribed a set of arcane formulas in your " +
                                          "spellbook that you can use to formulate a cantrip in your mind. " +
                                          "Whenever you finish a long rest and consult those formulas in " +
                                          "your spellbook, you can replace one wizard cantrip you know " +
                                          "with another cantrip from the wizard spell list."
                        },
                        new()
                        {
                            Name = "Ability Score Improvement",
                            Description = "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, " +
                                          "you can increase one ability score of your choice by 2, or you can increase " +
                                          "two ability scores of your choice by 1. As normal, you can't increase an " +
                                          "ability score above 20 using this feature."
                        }
                    },
                    Spells = new List<Spell>()
                    {
                        fireballCantrip, fireballFirstLevel, fireballSecondLevel, fireball,
                        fireballFourthLevel, fireballFifthLevel, fireballSixthLevel, fireballSeventhLevel,
                        fireballEighthLevel, fireballNinthLevel
                    },
                    Subclasses = new List<Subclass>()
                    {
                        new()
                        {
                            Name = "School of Evocation",
                            Source = "Basic Rules",
                            Description = "You focus your study on magic that creates powerful elemental effects " +
                                          "such as bitter cold, searing flame, rolling thunder, crackling lightning, " +
                                          "and burning acid. Some evokers find employment in military forces, serving " +
                                          "as artillery to blast enemy armies from afar. Others use their " +
                                          "spectacular power to protect the weak, while some seek their own " +
                                          "gain as bandits, adventurers, or aspiring tyrants.",
                            Features = new List<Feature>()
                            {
                                new()
                                {
                                    Name = "Evocation Savant", 
                                    Description = "Beginning when you select this school at 2nd level, the " +
                                                  "gold and time you must spend to copy a Evocation spell into " +
                                                  "your spellbook is halved."
                                }    
                            }
                        }
                    }
                    
                };

                #endregion
                
                context.Spells.AddRange(fireballCantrip, fireballFirstLevel, fireballSecondLevel, 
                                        fireball, fireballFourthLevel, fireballFifthLevel, fireballSixthLevel,
                                        fireballSeventhLevel, fireballEighthLevel, fireballNinthLevel);
                context.Feats.AddRange(sentinel, lucky, alert);
                context.Lineages.AddRange(human, dwarf);
                context.Classes.Add(wizard);

                context.SaveChanges();
            }
        }
    }
}
