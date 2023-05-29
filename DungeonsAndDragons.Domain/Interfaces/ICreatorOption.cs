using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonsAndDragons.Domain
{
	public interface ICreatorOption
	{
		public string Name { get; set; }
		public string Source { get; set; }
		public string Description { get; set; }
	}
}