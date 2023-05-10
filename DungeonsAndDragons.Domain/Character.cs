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
		public IEnumerable<Background> Backgrounds { get; set; } = null!;
		public IEnumerable<CharacterClass> Classes { get; set; } = null!;
		public IEnumerable<CharacterStat> Stats { get; set; } = null!;
		public IEnumerable<CharacterSkill> Skills { get; set; } = null!;
		public IEnumerable<SavingThrow> SavingThrows { get; set; } = null!;
		public IEnumerable<Spell>? Spells { get; set; }
		public IEnumerable<Feat>? Feats { get; set; }

		//Roleplay character info
		public string Age { get; set; } = null!;
		public string Height { get; set; } = null!;
		public string Weight { get; set; } = null!;
		public string EyeColour { get; set; } = null!;
		public string SkinColour { get; set; } = null!;
		public string HairColour { get; set; } = null!;
		public string Backstory { get; set; } = null!;
		public string Personality { get; set; } = null!;
		public string Ideals { get; set; } = null!;
		public string Bonds { get; set; } = null!;
		public string Flaws { get; set; } = null!;
		public string AppearanceDescription { get; set; } = null!;
		public string AlliesAndOrganizations { get; set; } = null!;
		public string AdditionalTraitsAndFeatures { get; set; } = null!;
		public string Treasure { get; set; } = null!;
		public IEnumerable<Language> Languages { get; set; } = null!;

		public int TotalLevels() 
		{
			return Classes.Sum(c => c.Level);
		}
	}
}