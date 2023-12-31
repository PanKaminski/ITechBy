﻿// <auto-generated />
using System;
using Infrastructure.Implementations.DataMaster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Implementations.Migrations
{
    [DbContext(typeof(ITechDbContext))]
    [Migration("20231020191607_EnhanceTokenRestrictions")]
    partial class EnhanceTokenRestrictions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Services.Abstractions.Data.Account.AchievementEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChangedByAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("achievements", "db");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.ConnectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserFromId")
                        .HasColumnType("int");

                    b.Property<int>("UserToId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserFromId");

                    b.HasIndex("UserToId");

                    b.ToTable("connections", "db");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("roles", "auth");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2011),
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2014),
                            Type = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2015),
                            Type = 3
                        });
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.SocialLinkEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("SocialType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("social_links", "db");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChangedByAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(36)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("PasswordResetTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ResetToken")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VerificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.ToTable("users", "auth");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Account.RefreshTokenEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("refresh_tokens", "auth");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.ConversationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("conversations", "msg");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.MediaAttachmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChangedByAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("attachments", "msg");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.MessageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChangedByAccount")
                        .HasColumnType("int");

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("SenderId");

                    b.ToTable("messages", "msg");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.UserConversationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.Property<int>("ConversationRoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("ConversationRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("user_conversations", "msg");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.UserConversationRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("conversation_roles", "msg");
                });

            modelBuilder.Entity("user_achievements", b =>
                {
                    b.Property<int>("AchievementsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int?>("AchievementId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AchievementsId", "UsersId");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("user_achievements");
                });

            modelBuilder.Entity("user_roles", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("user_roles", "auth");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.ConnectionEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "UserFrom")
                        .WithMany("Following")
                        .HasForeignKey("UserFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "UserTo")
                        .WithMany("Followers")
                        .HasForeignKey("UserToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("UserFrom");

                    b.Navigation("UserTo");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.SocialLinkEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "User")
                        .WithMany("SocialLinks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Account.RefreshTokenEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "User")
                        .WithOne("RefreshToken")
                        .HasForeignKey("Services.Abstractions.Data.Entities.Account.RefreshTokenEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.MediaAttachmentEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Entities.Communication.MessageEntity", "Message")
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.MessageEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Entities.Communication.ConversationEntity", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.UserConversationEntity", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Entities.Communication.ConversationEntity", "Conversation")
                        .WithMany("UserConversations")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Entities.Communication.UserConversationRoleEntity", "ConversationRole")
                        .WithMany("UserConversations")
                        .HasForeignKey("ConversationRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "User")
                        .WithMany("Conversations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("ConversationRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("user_achievements", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Account.AchievementEntity", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId");

                    b.HasOne("Services.Abstractions.Data.Account.AchievementEntity", null)
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("user_roles", b =>
                {
                    b.HasOne("Services.Abstractions.Data.Account.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Services.Abstractions.Data.Account.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Services.Abstractions.Data.Account.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Account.UserEntity", b =>
                {
                    b.Navigation("Conversations");

                    b.Navigation("Followers");

                    b.Navigation("Following");

                    b.Navigation("Messages");

                    b.Navigation("RefreshToken");

                    b.Navigation("SocialLinks");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.ConversationEntity", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserConversations");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.MessageEntity", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("Services.Abstractions.Data.Entities.Communication.UserConversationRoleEntity", b =>
                {
                    b.Navigation("UserConversations");
                });
#pragma warning restore 612, 618
        }
    }
}
