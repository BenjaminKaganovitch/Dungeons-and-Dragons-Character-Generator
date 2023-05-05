using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungeons___Dragons.Models;

namespace Dungeons___Dragons.Domain
{
	public class Lineage
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Source { get; set; } = null!;
		public string? CreatorId { get; set; }
		public UserLeadEntity? Creator { get; set; }

        
	}
}