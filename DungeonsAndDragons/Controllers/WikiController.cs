using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.Controllers
{
	public class WikiController : Controller
	{
		public IActionResult WikiHomePage()
		{
			return View();
		}
	}
}
