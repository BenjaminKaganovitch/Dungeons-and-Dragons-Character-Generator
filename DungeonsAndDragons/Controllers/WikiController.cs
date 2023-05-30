using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.Controllers
{
	public class WikiController : Controller
	{

        private readonly ApplicationDbContext _db;

        public WikiController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult WikiHomePage()
		{
			return View();
		}

		public IActionResult WikiSpellPage(int id)
		{
			if(id == null)
			{
				return NotFound();
			}
			Spell spell = _db.Spells.Include(s=>s.Creator).FirstOrDefault(s => s.Id == id);
			if(spell == null)
			{
				return NotFound();
			}
			return View(spell);
		}
        public IActionResult WikiFeatPage(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Feat feat = _db.Feats.Include(f => f.Creator).Include(f => f.Spells).FirstOrDefault(f => f.Id == id);
            if (feat == null)
            {
                return NotFound();
            }
            return View(feat);
        }
        public IActionResult WikiLineagePage(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Lineage lineage = _db.Lineages
                .Include(l=>l.Creator)
                .Include(l => l.Sublineages).ThenInclude(s=>s.Features)
                .Include(l => l.Sublineages).ThenInclude(s => s.Spells)
                .Include(l => l.Sublineages).ThenInclude(s => s.StatBoosts)
                .Include(l => l.StatBoosts)
                .Include(l => l.Features)
                .FirstOrDefault(l => l.Id == id);
            if (lineage == null)
            {
                return NotFound();
            }
            return View(lineage);
        }
    }
}
