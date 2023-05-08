using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class CharacterSkill
	{
		public int CharacterId { get; set; }
		public int SkillId { get; set; }
		public Character Character { get; set; } = null!;
		public Skill Skill { get; set; } = null!;
		public ProficiencyLevel ProficiencyLevel { get; set; }
	}
}