using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Character
	{
		public int Id { get; set; }
		public string CreatorId { get; set; } = null!;
		public UserLeadEntity Creator { get; set; } = null!;

		//Gameplay character info
		public string Name { get; set; } = null!;
		public string Alignment { get; set; } = null!;
		public int LineageId { get; set; }
		public Lineage Lineage { get; set; } = null!;
		public int SublineageId { get; set; }
		public Sublineage Sublineage { get; set; } = null!;
		public ICollection<Background> Backgrounds { get; set; } = new List<Background>();
		public ICollection<CharacterClass> Classes { get; set; } = new List<CharacterClass>();
		public ICollection<CharacterStat> Stats { get; set; } = new List<CharacterStat>();
		public ICollection<CharacterSkill> Skills { get; set; } = new List<CharacterSkill>();
		public ICollection<SavingThrow> SavingThrows { get; set; } = new List<SavingThrow>();
		public ICollection<Spell> Spells { get; set; } = new List<Spell>();
		public ICollection<Feat> Feats { get; set; } = new List<Feat>();

		//Roleplay character info
		public string? Age { get; set; }
		public string? Height { get; set; }
		public string? Weight { get; set; }
		public string? EyeColour { get; set; }
		public string? SkinColour { get; set; }
		public string? HairColour { get; set; }
		public string? Backstory { get; set; }
		public string? Personality { get; set; }
		public string? Ideals { get; set; }
		public string? Bonds { get; set; }
		public string? Flaws { get; set; }
		public string? AppearanceDescription { get; set; }
		public string? AlliesAndOrganizations { get; set; }
		public string? AdditionalTraitsAndFeatures { get; set; }
		public string? Treasure { get; set; }
		public ICollection<Language> Languages { get; set; } = new List<Language>();

		public int TotalLevels() 
		{
			return Classes.Sum(c => c.Level);
		}
	}
}