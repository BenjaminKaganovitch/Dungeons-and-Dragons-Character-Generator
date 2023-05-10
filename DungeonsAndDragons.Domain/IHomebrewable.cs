using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonsAndDragons.Identity;

namespace DungeonsAndDragons.Domain
{
	public interface IHomebrewable : ICreatorOption
	{
		public string? CreatorId { get; set; }
        public UserLeadEntity? Creator {get; set;}
	}
}