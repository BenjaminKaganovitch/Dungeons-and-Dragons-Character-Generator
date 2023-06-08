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

		public HomebrewController(ApplicationDbContext context, 
			UserManager<UserLeadEntity> manager, SignInManager<UserLeadEntity> signin)
		{
			_context = context;
			_manager = manager;
			_signInManager = signin;
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

		public IActionResult SpellsHomebrew()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> SpellsHomebrew(SpellCreatingModel model, string[] spellComponents, string? materials)
        {
			string c = string.Join(", ", spellComponents);

			if (materials != null)
			{
				c = $"{c}({materials})";
			}

			Spell spell = new()
			{
				Name = model.Name,
				Description = model.Description,
				Range = model.Range,
				Duration = model.Duration,
				Components = c,
				Creator = await _manager.GetUserAsync(User),
				MagicSchool = model.MagicSchool,
				SpellType = model.SpellType,
				CastingTime = model.CastingTime,
				Source = model.Source
			};

			_context.Spells.Add(spell);
			_context.SaveChanges();

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
