using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Sublineage : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public Size Size { get; set; }
		public string MovementSpeed { get; set; } = null!;
		public ICollection<Feature> Features { get; set; } = new List<Feature>();
		public ICollection<StatBoost> StatBoosts { get; set; } = new List<StatBoost>();
		public ICollection<Spell> Spells { get; set; } = new List<Spell>();
	}
}