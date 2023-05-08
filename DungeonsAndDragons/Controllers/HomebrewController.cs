using Microsoft.AspNetCore.Mvc;

namespace Dungeons___Dragons.Controllers
{
	public class HomebrewController : Controller
	{
		public IActionResult CreateHomebrew()
		{
			return View();
		}

        public IActionResult ViewHomebrew()
        {
            return View();
        }
    }
}
