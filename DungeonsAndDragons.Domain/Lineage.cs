using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Lineage : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public ICollection<StatBoost> StatBoosts { get; set; } = new List<StatBoost>();
		public ICollection<Feature> Features { get; set; } = new List<Feature>();
		public ICollection<Sublineage> Sublineages { get; set; } = new List<Sublineage>();
	}
}