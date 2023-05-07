using Dungeons___Dragons.Models;

namespace Dungeons___Dragons.Domain
{
	public class Subclass : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public IEnumerable<Feature> Features { get; set; } = null!;
		public IEnumerable<Spell>? Spells { get; set; }
	}
}