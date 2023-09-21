﻿using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Communication;

namespace Infrastructure.Implementations.DataMaster
{
    public class ITechDbContext : DbContext
    {
        public ITechDbContext(DbContextOptions options) : base(options) { }

        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<AchievementEntity> UserAchievements { get; set; }
        public DbSet<ConnectionEntity> Connections { get; set; }
        public DbSet<SocialLinkEntity> SocialLinks { get; set; }
        public DbSet<ConversationEntity> Conversations { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserConversationRoleEntity> ConversationRoles { get; set; }
        public DbSet<UserConversationEntity> UserConversations { get; set; }
        public DbSet<MediaAttachmentEntity> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureTableNames(modelBuilder);
            ConfigureDataTypes(modelBuilder);
            ConfigureOneToManyRelations(modelBuilder);
            ConfigureOneToOneRelations(modelBuilder);
            ConfigureManyToManyRelations(modelBuilder);
        }

        private static void ConfigureDataTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(
                eb =>
                {
                    eb.Property(u => u.FirstName).HasColumnType("varchar(36)");
                    eb.Property(u => u.LastName).HasColumnType("varchar(36)");
                    eb.Property(u => u.Email).HasColumnType("varchar(36)");
                    eb.Property(u => u.PasswordHash).HasColumnType("varchar(64)");
                    eb.Property(u => u.PasswordSalt).HasColumnType("varchar(64)");
                    eb.Property(u => u.VerificationToken).HasColumnType("varchar(64)");
                    eb.Property(u => u.ResetToken).HasColumnType("varchar(64)");
                });
            modelBuilder.Entity<ConversationEntity>(
                eb =>
                {
                    eb.Property(u => u.Title).HasColumnType("varchar(64)");
                });
            modelBuilder.Entity<RefreshTokenEntity>(
                eb =>
                {
                    eb.Property(u => u.Source).HasColumnType("varchar(64)");
                });
            modelBuilder.Entity<SocialLinkEntity>(
                eb =>
                {
                    eb.Property(u => u.Link).HasColumnType("varchar(256)");
                });
        }

        private static void ConfigureTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("users", schema: "auth");
            modelBuilder.Entity<RefreshTokenEntity>().ToTable("refresh_tokens", schema: "auth");
            modelBuilder.Entity<RoleEntity>().ToTable("roles", schema: "auth");
            modelBuilder.Entity<SocialLinkEntity>().ToTable("social_links", schema: "db");
            modelBuilder.Entity<ConnectionEntity>().ToTable("connections", schema: "db");
            modelBuilder.Entity<AchievementEntity>().ToTable("user_achievements", schema: "db");
            modelBuilder.Entity<ConversationEntity>().ToTable("conversations", schema: "msg");
            modelBuilder.Entity<MessageEntity>().ToTable("messages", schema: "msg");
            modelBuilder.Entity<UserConversationRoleEntity>().ToTable("conversation_roles", schema: "msg");
            modelBuilder.Entity<UserConversationEntity>().ToTable("user_conversations", schema: "msg");
            modelBuilder.Entity<MediaAttachmentEntity>().ToTable("attachments", schema: "msg");
        }

        private void ConfigureManyToManyRelations(ModelBuilder modelBuilder)
        {
            // User realtions
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Accounts)
                .UsingEntity(
                    "user_roles",
                    l => l.HasOne(typeof(UserEntity)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(UserEntity.Id)),
                    r => r.HasOne(typeof(RoleEntity)).WithMany().HasForeignKey("RoleId").HasPrincipalKey(nameof(RoleEntity.Id)),
                    j => j.HasKey("UserId", "RoleId")
                 );
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Achievements)
                .WithMany(ac => ac.Users)
                .UsingEntity(
                    "user_achievements",
                    l => l.HasOne(typeof(UserEntity)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(UserEntity.Id)),
                    r => r.HasOne(typeof(AchievementEntity)).WithMany().HasForeignKey("AchievementId").HasPrincipalKey(nameof(AchievementEntity.Id)),
                    j => j.HasKey("UserId", "AchievementId")
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
            // Connection relations
            modelBuilder.Entity<ConnectionEntity>()
                .HasOne(c => c.UserTo)
                .WithMany(u => u.Followers)
                .HasForeignKey(c => c.UserToId)
                .IsRequired();
            modelBuilder.Entity<ConnectionEntity>()
                .HasOne(c => c.UserFrom)
                .WithMany(u => u.Following)
                .HasForeignKey(c => c.UserFromId)
                .IsRequired();
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
    }
}
