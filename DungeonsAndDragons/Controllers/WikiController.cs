using Microsoft.AspNetCore.Mvc;

namespace Dungeons___Dragons.Controllers
{
	public class WikiController : Controller
	{
		public IActionResult WikiHomePage()
		{
			return View();
		}
	}
}
