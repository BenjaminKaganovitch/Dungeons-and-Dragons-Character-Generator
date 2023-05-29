using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public class Background : IHomebrewable
	{
		public int Id { get; set; }
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string Description { get; set; } = null!;
        public ICollection<Feature> Features { get; set; } = new List<Feature>();
	}
}