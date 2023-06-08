using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.Controllers
{
	public class HomebrewController : Controller
	{
		private ApplicationDbContext _context;
		private readonly UserManager<UserLeadEntity> _manager;

		public HomebrewController(ApplicationDbContext context, 
			UserManager<UserLeadEntity> manager)
		{
			_context = context;
			_manager = manager;
		}

		public IActionResult CreateHomebrew()
		{
			return View();
		}

		public IActionResult CreateSpell()
		{
			if (!User.Identity.IsAuthenticated)
				return NotFound();
			
			return View();
		}
		
		public IActionResult CreateBackground()
		{
			if (!User.Identity.IsAuthenticated)
				return NotFound();
			
			return View();
		}

        public IActionResult ViewHomebrew()
        {
            return View();
        }
    }
}
