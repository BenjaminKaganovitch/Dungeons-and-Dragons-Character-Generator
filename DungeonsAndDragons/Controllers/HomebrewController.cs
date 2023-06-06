using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.Controllers
{
	public class HomebrewController : Controller
	{
		public IActionResult CreateHomebrew()
		{
			return View();
		}

		public IActionResult CreateSpell()
		{
			return View();
		}

        public IActionResult ViewHomebrew()
        {
            return View();
        }
    }
}
