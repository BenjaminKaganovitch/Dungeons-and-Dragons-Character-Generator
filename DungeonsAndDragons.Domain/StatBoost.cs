using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class StatBoost
	{
		public int Id { get; set; }
		public int LineageId { get; set; }
		public Stat Stat { get; set; }
		public int Value { get; set; }
		public Lineage Lineage { get; set; } = null!;
	}
}