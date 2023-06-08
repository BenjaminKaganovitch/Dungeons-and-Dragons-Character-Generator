using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Domain;
using DungeonsAndDragons.Identity;
using DungeonsAndDragons.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.Controllers
{
	public class HomebrewController : Controller
	{
		private ApplicationDbContext _context;
		private readonly UserManager<UserLeadEntity> _manager;
		private DataService _service;

		public HomebrewController(ApplicationDbContext context, 
			UserManager<UserLeadEntity> manager, DataService service)
		{
			_context = context;
			_manager = manager;
			_service = service;
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
