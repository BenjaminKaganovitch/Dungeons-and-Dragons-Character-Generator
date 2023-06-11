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
		private readonly UserManager<UserLeadEntity> _manager;
		private SignInManager<UserLeadEntity> _signInManager;
		private IDataService _service;

		public HomebrewController(UserManager<UserLeadEntity> manager, IDataService service, 
			SignInManager<UserLeadEntity> signin)
		{
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
				
				Spell spell = _service.CreateHomebrewSpell(model, c, _manager.GetUserId(User));

				return RedirectToAction("WikiSpellPage", "Wiki", new {id = spell.Id});
	        }
	        
			return SpellsHomebrew();
        }

		public IActionResult ViewHomebrew()
        {
            return View();
        }

		public IActionResult BackgroundHomebrew()
		{
			if (!User.Identity.IsAuthenticated)
				return Forbid();

			return View();
		}

		[HttpPost]
		public IActionResult BackgroundHomebrew(BackgroundCreatingModel model)
		{
			if (ModelState.IsValid)
			{
				Background background = _service.CreateHomebrewBackground(model, _manager.GetUserId(User));

				return RedirectToAction("WikiBackgroundPage", "Wiki", new {id = background.Id});
			}

			return BackgroundHomebrew();
		}

		public IActionResult FeatsHomebrew()
		{
			if (!User.Identity.IsAuthenticated)
				return Forbid();

			return View();
		}
		
		[HttpPost]
		public IActionResult FeatsHomebrew(FeatCreatingModel model)
		{
			if (ModelState.IsValid)
			{
				Feat feat = _service.CreateHomebrewFeat(model, _manager.GetUserId(User));

				return RedirectToAction("WikiFeatPage", "Wiki", new {id = feat.Id});
			}

			return FeatsHomebrew();
		}
	}
}
