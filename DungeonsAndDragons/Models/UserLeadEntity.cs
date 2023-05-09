using Microsoft.AspNetCore.Identity;
using Dungeons___Dragons.Domain;

namespace Dungeons___Dragons.Models
{
	public class UserLeadEntity : IdentityUser
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string Mobile { get; set; } = null!;
		public IEnumerable<Character> Characters { get; set; } = null!;
		public IEnumerable<Feat> HomebrewFeats { get; set; } = null!;
		public IEnumerable<Subclass> HomebrewSubclasses { get; set; } = null!;
		public IEnumerable<Spell> HomebrewSpells { get; set; } = null!;
		public IEnumerable<Background> HomebrewBackgrounds { get; set; } = null!;
		public IEnumerable<Lineage> HomebrewLineages { get; set; } = null!;
		public IEnumerable<Sublineage> HomebrewSublineages { get; set; } = null!;
		public string AcceptedSources { get; set; } = null!;
	}
}
