using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonsAndDragons.Domain
{
	public class Class : ICreatorOption
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public DieType HitDieType { get; set; }
		public int SubclassUnlockLevel { get; set; }
		public string Description { get; set; } = null!;
		public ICollection<Feature> Features { get; set; } = new List<Feature>();
		public ICollection<Spell> Spells { get; set; } = new List<Spell>();
		public ICollection<Subclass> Subclasses { get; set; } = new List<Subclass>();
	}
}