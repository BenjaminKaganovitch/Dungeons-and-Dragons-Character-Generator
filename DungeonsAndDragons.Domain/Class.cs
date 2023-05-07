using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class Class : ICreatorOption
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public DieType HitDieType { get; set; }
		public string Description { get; set; } = null!;
		public IEnumerable<Feature> Features { get; set; } = null!;
		//Not all classes can use spells, so this is nullable
		public IEnumerable<Spell>? Spells { get; set; }
		public IEnumerable<Subclass> Subclasses { get; set; } = null!;
	}
}