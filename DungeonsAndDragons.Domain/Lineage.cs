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
		public string Size { get; set; } = null!;
		public IEnumerable<StatBoost> StatBoosts { get; set; } = null!;
		public IEnumerable<Feature> Features { get; set; } = null!;
		public IEnumerable<Sublineage> Sublineages { get; set; } = null!;
	}
}