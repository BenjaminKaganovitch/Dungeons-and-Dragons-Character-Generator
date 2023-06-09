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
		private SignInManager<UserLeadEntity> _signInManager;
		private DataService _service;

		public HomebrewController(ApplicationDbContext context, 
			UserManager<UserLeadEntity> manager, DataService service, SignInManager<UserLeadEntity> signin)
		{
			_context = context;
			_manager = manager;
			_service = service;
			_signInManager = signin;
		}

		public IActionResult CreateHomebrew()
		{
			return View();
		}

		public IActionResult SpellsHomebrew()
		{
			if (!User.Identity.IsAuthenticated)
				return Forbid();
			
			return View();
		}
		[HttpPost]
        public IActionResult SpellsHomebrew(SpellCreatingModel model, string[] spellComponents, string? materials)
        {
	        if (ModelState.IsValid)
	        {
				string c = string.Join(", ", spellComponents);

				if (materials != null)
				{
					c = $"{c}({materials})";
				}
				
				_service.CreateHomebrewSpell(model, _manager.GetUserId(User), c);
		        
	        }
	        
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
