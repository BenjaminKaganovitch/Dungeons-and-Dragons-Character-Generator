using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Spell : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public SpellType SpellType { get; set; }
		public string MagicSchool { get; set; } = null!;
		public string CastingTime { get; set; } = null!;
		public string Range { get; set; } = null!;
		public string Components { get; set; } = null!;
		public string Duration { get; set; } = null!;
		public string Description { get; set; } = null!;
	}
}