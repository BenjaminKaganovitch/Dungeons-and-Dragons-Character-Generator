using Microsoft.AspNet.Identity.EntityFramework;

namespace DungeonsAndDragons.Identity
{
    public class UserLeadEntity : IdentityUser
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string Mobile { get; set; } = null!;
		public string AcceptedSources { get; set; } = null!;
	}
}
