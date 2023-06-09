using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Subclass : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public ICollection<Feature> Features { get; set; } = new List<Feature>();
		public ICollection<Spell> Spells { get; set; } = new List<Spell>();
	}
}