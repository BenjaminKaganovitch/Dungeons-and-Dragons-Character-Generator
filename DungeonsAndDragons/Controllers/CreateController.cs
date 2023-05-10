using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.Controllers
{
	public class CreateController : Controller
	{
		public IActionResult CharacterCreator()
		{
			return View();
		}
	}
}
