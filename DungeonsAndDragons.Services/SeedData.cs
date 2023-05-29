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

                // Lineage human = new()
                // {
                //     Name = "Human",
                //     Source = "Basic Rules",
                //     Description = "Humans are the most common and widespread race in many fantasy settings. They come in " +
                //                   "various ethnicities and cultures, displaying a wide range of appearances, beliefs, and" +
                //                   " abilities. Humans are adaptable and versatile, capable of excelling in various " +
                //                   "professions and roles.",
                //     Sublineages = new List<Sublineage>()
                //     {
                //         new()
                //         {
                //             Name = "Standard Human",
                //             Source = "Basic Rules",
                //             Size = Size.Medium,
                //             MovementSpeed = "30 feet (walking)",
                //             StatBoosts = new List<StatBoost>()
                //             {
                //                 new(){Stat = Stat.Strength, Value = 1},
                //                 new(){Stat = Stat.Dexterity, Value = 1},
                //                 new(){Stat = Stat.Constitution, Value = 1},
                //                 new(){Stat = Stat.Intelligence, Value = 1},
                //                 new(){Stat = Stat.Wisdom, Value = 1},
                //                 new(){Stat = Stat.Charisma, Value = 1}
                //             }
                //         },
                //         new()
                //         {
                //             Name = "Variant Human",
                //             Source = "Basic Rules",
                //             Size = Size.Medium,
                //             MovementSpeed = "30 feet (walking)",
                //             StatBoosts = new List<StatBoost>()
                //             {
                //                 new() {Stat = Stat.Any, Value = 1},
                //                 new() {Stat = Stat.Any, Value = 1}
                //             },
                //             Features = new List<Feature>()
                //             {
                //                 new() {Name = "Feat", Description = "You gain one Feat of your choice."}
                //             }
                //             
                //         }
                //     }
                // };
                //
                // Lineage dwarf = new()
                // {
                //     Name = "Dwarf",
                //     Source = "Basic Rules",
                //     Description = "Dwarves are a short and stout humanoid race known for their craftsmanship, resilience," +
                //                   " and affinity for mining and underground life. They are often associated with " +
                //                   "mountains and have a reputation for their love of ale and strong spirits.",
                //     StatBoosts = new List<StatBoost>()
                //     {
                //         new() { Stat = Stat.Constitution, Value = 2 }
                //     },
                //     Features = new List<Feature>()
                //     {
                //         new()
                //         {
                //             Name = "Darkvision",
                //             Description = "Accustomed to life underground, you have superior vision in dark and dim " +
                //                           "conditions. You can see in dim light within 60 feet of you as if it were " +
                //                           "bright light, and in darkness as if it were dim light. You can’t discern " +
                //                           "color in darkness, only shades of gray."
                //         },
                //         new()
                //         {
                //             Name = "Dwarven Resilience",
                //             Description = "You have advantage on saving throws against poison, and you have " +
                //                           "resistance against poison damage."
                //         },
                //         new()
                //         {
                //             Name = "Dwarven Combat Training",
                //             Description = "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer."
                //         },
                //         new()
                //         {
                //             Name = "Tool Proficiency",
                //             Description = "You gain proficiency with the artisan’s tools of your choice: smith’s tools, " +
                //                           "brewer’s supplies, or mason’s tools."
                //         },
                //         new()
                //         {
                //             Name = "Stonecunning",
                //             Description = "Whenever you make an Intelligence (History) check related to the origin of " +
                //                           "stonework, you are considered proficient in the History skill and add double " +
                //                           "your proficiency bonus to the check, instead of your normal proficiency bonus."
                //         }
                //     },
                //     Sublineages = new List<Sublineage>()
                //     {
                //         new()
                //         {
                //             Name = "Hill Dwarf",
                //             Source = "Basic Rules",
                //             Size = Size.Medium,
                //             MovementSpeed = "25 feet (walking)",
                //             Description = "As a hill dwarf, you have keen senses, deep intuition, and remarkable " +
                //                           "resilience. The gold dwarves of Faerun in their mighty southern kingdom " +
                //                           "are hill dwarves, as are the exiled Neidar and the debased Klar of " +
                //                           "Krynn in the Dragonlance setting.",
                //             StatBoosts = new List<StatBoost>()
                //             {
                //                 new() { Stat = Stat.Wisdom, Value = 1 }
                //             },
                //             Features = new List<Feature>()
                //             {
                //                 new()
                //                 {
                //                     Name = "Dwarven Toughness",
                //                     Description = "Your hit point maximum increases by 1, and it increases by 1 every " +
                //                                   "time you gain a level."
                //                 }
                //             }
                //         },
                //         new()
                //         {
                //             Name = "Mountain Dwarf",
                //             Source = "Basic Rules",
                //             Size = Size.Medium,
                //             MovementSpeed = "25 feet (walking)",
                //             Description = "As a mountain dwarf, you’re strong and hardy, " +
                //                           "accustomed to a difficult life in rugged terrain. You’re " +
                //                           "probably on the tall side (for a dwarf), and tend toward " +
                //                           "lighter coloration. The shield dwarves of northern " +
                //                           "Faerûn, as well as the ruling Hylar clan and the noble" +
                //                           "Daewar clan of Dragonlance, are mountain dwarves.",
                //             StatBoosts = new List<StatBoost>()
                //             {
                //                 new() { Stat = Stat.Strength, Value = 2 }
                //             },
                //             Features = new List<Feature>()
                //             {
                //                 new()
                //                 {
                //                     Name = "Dwarven Armor Training",
                //                     Description = "You have proficiency with light and medium armor."
                //                 }
                //             }
                //         }
                //     }
                // };

                #endregion

                #region Classes

                // Class wizard = new()
                // {
                //     Name = "Wizard",
                //     Source = "Basic Rules",
                //     Description = ""
                // };

                #endregion
                
                context.Spells.AddRange(fireballCantrip, fireballFirstLevel, fireballSecondLevel, 
                                        fireball, fireballFourthLevel, fireballFifthLevel, fireballSixthLevel,
                                        fireballSeventhLevel, fireballEighthLevel, fireballNinthLevel);
                context.Feats.AddRange(sentinel, lucky, alert);

                context.SaveChanges();
            }
        }
    }
}
