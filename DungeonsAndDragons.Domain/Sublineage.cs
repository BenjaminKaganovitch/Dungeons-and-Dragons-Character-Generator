using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungeons___Dragons.Models;

namespace Dungeons___Dragons.Domain
{
	public class Sublineage
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public Size Size { get; set; }
		public IEnumerable<Feature> Features { get; set; } = null!;
		public IEnumerable<StatBoost> StatBoosts { get; set; } = null!;
		public IEnumerable<Spell> Spells { get; set; } = null!;
	}
}