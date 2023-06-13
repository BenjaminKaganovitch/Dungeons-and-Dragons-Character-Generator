using DungeonsAndDragons.Identity;
using DungeonsAndDragons.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.DataAccess
{
	public class ApplicationDbContext : IdentityDbContext<UserLeadEntity>
	{
		public ApplicationDbContext()
		{

		}

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
		public virtual DbSet<UserLeadEntity> Users { get; set; }
		public virtual DbSet<Character> Characters { get; set; }
		public virtual DbSet<Background> Backgrounds { get; set; }
		public virtual DbSet<Lineage> Lineages { get; set; }
		public virtual DbSet<Sublineage> Sublineages { get; set; }
		public virtual DbSet<Class> Classes { get; set; }
		public virtual DbSet<Subclass> Subclasses { get; set; }
		public virtual DbSet<CharacterClass> CharacterClasses { get; set; }
		public virtual DbSet<Skill> Skills { get; set; }
		public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }
		public virtual DbSet<CharacterStat> CharacterStats { get; set; }
		public virtual DbSet<StatBoost> StatBoosts { get; set; }
		public virtual DbSet<Feature> Features { get; set; }
		public virtual DbSet<Spell> Spells { get; set; }
		public virtual DbSet<Feat> Feats { get; set; }
		public virtual DbSet<Language> Languages { get; set; }
	}
}
