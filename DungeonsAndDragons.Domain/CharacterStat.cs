using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class CharacterStat
	{
		public int CharacterId { get; set; }
		public Stat Stat { get; set; }
		public Character Character { get; set; } = null!;
		public int Value { get; set; }
	}
}