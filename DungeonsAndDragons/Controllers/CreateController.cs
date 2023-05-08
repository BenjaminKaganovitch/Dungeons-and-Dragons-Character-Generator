using Microsoft.AspNetCore.Mvc;

namespace Dungeons___Dragons.Controllers
{
	public class CreateController : Controller
	{
		public IActionResult CharacterCreator()
		{
			return View();
		}
	}
}
