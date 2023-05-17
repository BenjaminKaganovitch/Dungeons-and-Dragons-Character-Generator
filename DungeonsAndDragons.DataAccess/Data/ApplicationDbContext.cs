using DungeonsAndDragons.Identity;
using DungeonsAndDragons.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.DataAccess
{
	public class ApplicationDbContext : IdentityDbContext<UserLeadEntity>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<CharacterClass>().
				HasKey(cc => new { cc.CharacterId, cc.ClassId });
			builder.Entity<CharacterStat>().
				HasKey(cs => new { cs.CharacterId, cs.Stat });
			builder.Entity<CharacterSkill>().
				HasKey(cs => new { cs.CharacterId, cs.SkillId });
			builder.Entity<SavingThrow>().
				HasKey(st => new { st.CharacterId, st.Stat });
		}

		//Regular
		public DbSet<UserLeadEntity> Users { get; set; }
		public DbSet<Character> Characters { get; set; }
		public DbSet<Background> Backgrounds { get; set; }
		public DbSet<Lineage> Lineages { get; set; }
		public DbSet<Sublineage> Sublineages { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Subclass> Subclasses { get; set; }
		public DbSet<CharacterClass> CharacterClasses { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<CharacterSkill> CharacterSkills { get; set; }
		public DbSet<CharacterStat> CharacterStats { get; set; }
		public DbSet<StatBoost> StatBoosts { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Spell> Spells { get; set; }
		public DbSet<Feat> Feats { get; set; }
		public DbSet<Language> Languages { get; set; }
		//Homebrew
		public DbSet<Spell> HomebrewSpells { get; set; }
		public DbSet<Feat> HomebrewFeats { get; set; }
		public DbSet<Lineage> HomebrewLineages { get; set; }
		public DbSet<Sublineage> HomebrewSublineages { get; set; }
		public DbSet<Subclass> HomebrewSubclasses { get; set; }
		public DbSet<Background> HomebrewBackgrounds { get; set; }
	}
}
