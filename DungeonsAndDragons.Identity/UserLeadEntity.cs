using Microsoft.AspNetCore.Identity;

namespace Dungeons___Dragons.Models
{
	public class UserLeadEntity : IdentityUser
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string Mobile { get; set; } = null!;
		public string AcceptedSources { get; set; } = null!;
	}
}
