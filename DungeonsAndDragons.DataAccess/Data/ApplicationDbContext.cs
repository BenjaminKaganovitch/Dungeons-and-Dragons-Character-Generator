using DungeonsAndDragons.Identity;
using DungeonsAndDragons.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.DataAccess
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		// Table
		public DbSet<UserLeadEntity> Users { get; set; }
		public DbSet<Character> Characters { get; set; }
		public DbSet<Spell> Spells { get; set; }
		public DbSet<Spell> HomebrewSpells { get; set; }
		public DbSet<Feat> Feats { get; set; }
		public DbSet<Feat> HomebrewFeats { get; set; }
		public DbSet<Lineage> Lineages { get; set; }
		public DbSet<Lineage> HomebrewLineages { get; set; }
		public DbSet<Sublineage> Sublineages { get; set; }
		public DbSet<Sublineage> HomebrewSublineages { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Subclass> Subclasses { get; set; }
		public DbSet<Subclass> HomebrewSubclasses { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Language> Languages { get; set; }
		
	}
}
