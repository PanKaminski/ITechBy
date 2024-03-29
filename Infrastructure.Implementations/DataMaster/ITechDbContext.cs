﻿using Domain.Common.Enums;
using Infrastructure.Implementations.DataMaster.Utils;
using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Communication;
using Services.Abstractions.Data.Entities.Learning;

namespace Infrastructure.Implementations.DataMaster
{
    public class ITechDbContext : DbContext
    {
        public ITechDbContext(DbContextOptions options) : base(options) { }

        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<AchievementEntity> Achievements { get; set; }
        public DbSet<ConnectionEntity> Connections { get; set; }
        public DbSet<SocialLinkEntity> SocialLinks { get; set; }
        public DbSet<ConversationEntity> Conversations { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserConversationRoleEntity> ConversationRoles { get; set; }
        public DbSet<UserConversationEntity> UserConversations { get; set; }
        public DbSet<MediaAttachmentEntity> Attachments { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<LanguageLevelEntity> LanguageLevels { get; set; }
        public DbSet<LanguageEntity> Languages { get; set; }
        public DbSet<UserLanguageEntity> UserLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureTableNames(modelBuilder);
            ConfigureDataTypes(modelBuilder);
            ConfigureOneToManyRelations(modelBuilder);
            ConfigureOneToOneRelations(modelBuilder);
            ConfigureManyToManyRelations(modelBuilder);
            //SeedData(modelBuilder);
        }

        private static void ConfigureDataTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(
                eb =>
                {
                    eb.Property(u => u.Avatar).HasColumnType("varchar(256)");
                    eb.Property(u => u.FirstName).HasColumnType("varchar(36)");
                    eb.Property(u => u.LastName).HasColumnType("varchar(36)");
                    eb.Property(u => u.Email).HasColumnType("varchar(36)");
                    eb.Property(u => u.PasswordHash).HasColumnType("varchar(256)");
                    eb.Property(u => u.PasswordSalt).HasColumnType("varchar(256)");
                    eb.Property(u => u.VerificationToken).HasColumnType("varchar(256)");
                    eb.Property(u => u.ResetToken).HasColumnType("varchar(256)");
                });
            modelBuilder.Entity<ConversationEntity>(eb => { eb.Property(u => u.Title).HasColumnType("varchar(64)"); });
            modelBuilder.Entity<RefreshTokenEntity>(eb =>{ eb.Property(u => u.Source).HasColumnType("varchar(256)"); });
            modelBuilder.Entity<SocialLinkEntity>(eb => { eb.Property(u => u.Link).HasColumnType("varchar(256)"); });
            modelBuilder.Entity<CountryEntity>(eb => { eb.Property(u => u.Code).HasColumnType("varchar(10)"); });
            modelBuilder.Entity<LanguageEntity>(eb => { eb.Property(u => u.Code).HasColumnType("varchar(10)"); });

            modelBuilder.Entity<LanguageLevelEntity>().Property(e => e.Level)
                .HasConversion(v => v.ToString(), v => (LanguageLevel)Enum.Parse(typeof(LanguageLevel), v));
            modelBuilder.Entity<RoleEntity>().Property(e => e.Type)
                .HasConversion(v => v.ToString(), v => (RoleType)Enum.Parse(typeof(RoleType), v));
        }

        private static void ConfigureTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("users", schema: "auth");
            modelBuilder.Entity<RefreshTokenEntity>().ToTable("refresh_tokens", schema: "auth");
            modelBuilder.Entity<RoleEntity>().ToTable("roles", schema: "auth");
            modelBuilder.Entity<SocialLinkEntity>().ToTable("social_links", schema: "db");
            modelBuilder.Entity<ConnectionEntity>().ToTable("connections", schema: "db");
            modelBuilder.Entity<AchievementEntity>().ToTable("achievements", schema: "db");
            modelBuilder.Entity<ConversationEntity>().ToTable("conversations", schema: "msg");
            modelBuilder.Entity<MessageEntity>().ToTable("messages", schema: "msg");
            modelBuilder.Entity<UserConversationRoleEntity>().ToTable("conversation_roles", schema: "msg");
            modelBuilder.Entity<UserConversationEntity>().ToTable("user_conversations", schema: "msg");
            modelBuilder.Entity<MediaAttachmentEntity>().ToTable("attachments", schema: "msg");
            modelBuilder.Entity<CountryEntity>().ToTable("countries", schema: "db");
            modelBuilder.Entity<LanguageLevelEntity>().ToTable("language_levels", schema: "lrn");
            modelBuilder.Entity<LanguageEntity>().ToTable("languages", schema: "lrn");
            modelBuilder.Entity<UserLanguageEntity>().ToTable("user_languages", schema: "lrn");
        }

        private void ConfigureManyToManyRelations(ModelBuilder modelBuilder)
        {
            // User realtions
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity<UserRoleEntity>(
                    "user_roles",
                    l => l.HasOne<RoleEntity>().WithMany().HasForeignKey(e => e.RoleId),
                    r => r.HasOne<UserEntity>().WithMany().HasForeignKey(e => e.UserId)
                );
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Achievements)
                .WithMany(ac => ac.Users)
                .UsingEntity<UserAchievementEntity>(
                    "user_achievements",
                    l => l.HasOne<AchievementEntity>().WithMany().HasForeignKey(e => e.AchievementsId),
                    r => r.HasOne<UserEntity>().WithMany().HasForeignKey(e => e.UsersId)
                 );
        }

        private void ConfigureOneToOneRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.RefreshToken)
                .WithOne(rt => rt.User)
                .HasForeignKey<RefreshTokenEntity>(rt => rt.UserId)
                .IsRequired();
        }

        private static void ConfigureOneToManyRelations(ModelBuilder modelBuilder)
        {
            // Social links relations
            modelBuilder.Entity<SocialLinkEntity>()
                .HasOne(sl => sl.User)
                .WithMany(u => u.SocialLinks)
                .HasForeignKey(sl => sl.UserId)
                .IsRequired();
            // Country relations
            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.Country)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CountryId)
                .IsRequired();
            // Connection relations
            modelBuilder.Entity<ConnectionEntity>()
                .HasOne(c => c.UserTo)
                .WithMany(u => u.Followers)
                .HasForeignKey(c => c.UserToId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ConnectionEntity>()
                .HasOne(c => c.UserFrom)
                .WithMany(u => u.Following)
                .HasForeignKey(c => c.UserFromId)
                .OnDelete(DeleteBehavior.NoAction);
            // Message relations
            modelBuilder.Entity<MessageEntity>()
                .HasOne(m => m.Conversation)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.ConversationId)
                .IsRequired();
            modelBuilder.Entity<MessageEntity>()
                .HasOne(m => m.Sender)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.SenderId)
                .IsRequired();
            // Media attachments relations
            modelBuilder.Entity<MediaAttachmentEntity>()
                .HasOne(m => m.Message)
                .WithMany(c => c.Attachments)
                .HasForeignKey(c => c.MessageId)
                .IsRequired(false);
            // Language relations
            modelBuilder.Entity<UserLanguageEntity>()
                .HasOne(ul => ul.User)
                .WithMany(u => u.Languages)
                .HasForeignKey(ul => ul.UserId)
                .IsRequired();
            modelBuilder.Entity<UserLanguageEntity>()
                .HasOne(ul => ul.Language)
                .WithMany(l => l.UserLanguages)
                .HasForeignKey(ul => ul.LanguageId)
                .IsRequired();
            modelBuilder.Entity<UserLanguageEntity>()
                .HasOne(ul => ul.Level)
                .WithMany(lvl => lvl.UserLanguages)
                .HasForeignKey(ul => ul.LevelId)
                .IsRequired();
            // Conversation relations
            modelBuilder.Entity<UserConversationEntity>()
                .HasOne(uc => uc.ConversationRole)
                .WithMany(r => r.UserConversations)
                .HasForeignKey(uc => uc.ConversationRoleId)
                .IsRequired();
            modelBuilder.Entity<UserConversationEntity>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.Conversations)
                .HasForeignKey(uc => uc.UserId)
                .IsRequired();
            modelBuilder.Entity<UserConversationEntity>()
                .HasOne(uc => uc.Conversation)
                .WithMany(c => c.UserConversations)
                .HasForeignKey(uc => uc.ConversationId)
                .IsRequired();
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleEntity>().HasData(
                new RoleEntity { Id = 1, Type = RoleType.Developer, CreatedTime = DateTime.UtcNow },
                new RoleEntity { Id = 2, Type = RoleType.Admin, CreatedTime = DateTime.UtcNow },
                new RoleEntity { Id = 3, Type = RoleType.User, CreatedTime = DateTime.UtcNow }
                );

            modelBuilder.Entity<LanguageLevelEntity>().HasData(
                new LanguageLevelEntity { Id = 1, Level = LanguageLevel.None, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 2, Level = LanguageLevel.Beginner, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 3, Level = LanguageLevel.Elementary, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 4, Level = LanguageLevel.Intermediate, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 5, Level = LanguageLevel.UpperIntermediate, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 6, Level = LanguageLevel.Advanced, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 7, Level = LanguageLevel.Proficiency, CreatedTime = DateTime.UtcNow },
                new LanguageLevelEntity { Id = 8, Level = LanguageLevel.Native, CreatedTime = DateTime.UtcNow }
                );

            modelBuilder.Entity<CountryEntity>().HasData(IntialDatabaseSetter.GetCountries());
            modelBuilder.Entity<LanguageEntity>().HasData(IntialDatabaseSetter.GetLanguages());
        }
    }
}
