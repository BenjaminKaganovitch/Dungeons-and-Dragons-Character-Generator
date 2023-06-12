﻿// <auto-generated />
using System;
using DungeonsAndDragons.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DungeonsAndDragons.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230612141705_ttttttttttgetnomobilethatmeansyoujohn")]
    partial class ttttttttttgetnomobilethatmeansyoujohn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DungeonsAndDragons.Domain.Background", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalTraitsAndFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlliesAndOrganizations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppearanceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Backstory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bonds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EyeColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flaws")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HairColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ideals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LineageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SublineageId")
                        .HasColumnType("int");

                    b.Property<string>("Treasure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LineageId");

                    b.HasIndex("SublineageId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterClass", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("SubclassId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubclassId");

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("ProficiencyLevel")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterStat", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Stat")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "Stat");

                    b.ToTable("CharacterStats");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanCast")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitDieType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubclassUnlockLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Feat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Feats");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LineageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubclassId")
                        .HasColumnType("int");

                    b.Property<int?>("SublineageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.HasIndex("ClassId");

                    b.HasIndex("LineageId");

                    b.HasIndex("SubclassId");

                    b.HasIndex("SublineageId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Lineage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Lineages");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.SavingThrow", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Stat")
                        .HasColumnType("int");

                    b.Property<bool>("IsProficient")
                        .HasColumnType("bit");

                    b.HasKey("CharacterId", "Stat");

                    b.ToTable("SavingThrow");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Spell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Components")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpellType")
                        .HasColumnType("int");

                    b.Property<int?>("SubclassId")
                        .HasColumnType("int");

                    b.Property<int?>("SublineageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ClassId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("SubclassId");

                    b.HasIndex("SublineageId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.StatBoost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LineageId")
                        .HasColumnType("int");

                    b.Property<int>("Stat")
                        .HasColumnType("int");

                    b.Property<int?>("SublineageId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LineageId");

                    b.HasIndex("SublineageId");

                    b.ToTable("StatBoosts");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Subclass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Subclasses");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Sublineage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LineageId")
                        .HasColumnType("int");

                    b.Property<string>("MovementSpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LineageId");

                    b.ToTable("Sublineages");
                });

            modelBuilder.Entity("DungeonsAndDragons.Identity.UserLeadEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Background", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", null)
                        .WithMany("Backgrounds")
                        .HasForeignKey("CharacterId");

                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Character", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Domain.Lineage", "Lineage")
                        .WithMany()
                        .HasForeignKey("LineageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Domain.Sublineage", "Sublineage")
                        .WithMany()
                        .HasForeignKey("SublineageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Lineage");

                    b.Navigation("Sublineage");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterClass", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", "Character")
                        .WithMany("Classes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Domain.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Domain.Subclass", "Subclass")
                        .WithMany()
                        .HasForeignKey("SubclassId");

                    b.Navigation("Character");

                    b.Navigation("Class");

                    b.Navigation("Subclass");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterSkill", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", "Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Domain.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.CharacterStat", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", "Character")
                        .WithMany("Stats")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Feat", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", null)
                        .WithMany("Feats")
                        .HasForeignKey("CharacterId");

                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Feature", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Background", null)
                        .WithMany("Features")
                        .HasForeignKey("BackgroundId");

                    b.HasOne("DungeonsAndDragons.Domain.Class", null)
                        .WithMany("Features")
                        .HasForeignKey("ClassId");

                    b.HasOne("DungeonsAndDragons.Domain.Lineage", null)
                        .WithMany("Features")
                        .HasForeignKey("LineageId");

                    b.HasOne("DungeonsAndDragons.Domain.Subclass", null)
                        .WithMany("Features")
                        .HasForeignKey("SubclassId");

                    b.HasOne("DungeonsAndDragons.Domain.Sublineage", null)
                        .WithMany("Features")
                        .HasForeignKey("SublineageId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Language", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", null)
                        .WithMany("Languages")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Lineage", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.SavingThrow", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", "Character")
                        .WithMany("SavingThrows")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Spell", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Character", null)
                        .WithMany("Spells")
                        .HasForeignKey("CharacterId");

                    b.HasOne("DungeonsAndDragons.Domain.Class", null)
                        .WithMany("Spells")
                        .HasForeignKey("ClassId");

                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("DungeonsAndDragons.Domain.Subclass", null)
                        .WithMany("Spells")
                        .HasForeignKey("SubclassId");

                    b.HasOne("DungeonsAndDragons.Domain.Sublineage", null)
                        .WithMany("Spells")
                        .HasForeignKey("SublineageId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.StatBoost", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Lineage", null)
                        .WithMany("StatBoosts")
                        .HasForeignKey("LineageId");

                    b.HasOne("DungeonsAndDragons.Domain.Sublineage", null)
                        .WithMany("StatBoosts")
                        .HasForeignKey("SublineageId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Subclass", b =>
                {
                    b.HasOne("DungeonsAndDragons.Domain.Class", null)
                        .WithMany("Subclasses")
                        .HasForeignKey("ClassId");

                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Sublineage", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("DungeonsAndDragons.Domain.Lineage", null)
                        .WithMany("Sublineages")
                        .HasForeignKey("LineageId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DungeonsAndDragons.Identity.UserLeadEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Background", b =>
                {
                    b.Navigation("Features");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Character", b =>
                {
                    b.Navigation("Backgrounds");

                    b.Navigation("Classes");

                    b.Navigation("Feats");

                    b.Navigation("Languages");

                    b.Navigation("SavingThrows");

                    b.Navigation("Skills");

                    b.Navigation("Spells");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Class", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("Spells");

                    b.Navigation("Subclasses");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Lineage", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("StatBoosts");

                    b.Navigation("Sublineages");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Subclass", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("Spells");
                });

            modelBuilder.Entity("DungeonsAndDragons.Domain.Sublineage", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("Spells");

                    b.Navigation("StatBoosts");
                });
#pragma warning restore 612, 618
        }
    }
}
