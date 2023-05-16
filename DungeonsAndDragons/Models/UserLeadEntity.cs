using Microsoft.AspNetCore.Identity;

namespace DungeonsAndDragons.Models
{
    public class UserLeadEntity : IdentityUser
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
    }
}
