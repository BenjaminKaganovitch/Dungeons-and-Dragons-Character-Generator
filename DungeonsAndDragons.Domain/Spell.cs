using Dungeons___Dragons.Models;

namespace Dungeons___Dragons.Domain
{
	public class Spell : IHomebrewable
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string? CreatorId { get; set; } = null!;
		public UserLeadEntity? Creator { get; set; } = null!;
		public Type SpellType { get; set; }
		public string MagicSchool { get; set; } = null!;
		public string Components { get; set; } = null!;
		public string Description { get; set; } = null!;

	}
}