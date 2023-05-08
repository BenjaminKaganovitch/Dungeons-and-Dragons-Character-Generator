using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class CharacterClass
	{
		public int CharacterId { get; set; }
		public int ClassId { get; set; }
		public int? SubclassId { get; set; }
		public Character Character { get; set; } = null!;
		public Class Class { get; set; } = null!;
		public Subclass? Subclass { get; set; }
		public int Level { get; set; }
	}
}