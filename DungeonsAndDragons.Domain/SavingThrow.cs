using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Domain
{
	public class SavingThrow
	{
		public int Id { get; set; }
		public Stat Stat { get; set; }
		public bool IsProficient { get; set; }
	}
}