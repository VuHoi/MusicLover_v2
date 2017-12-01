﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MusicLover.WebApp.Server.Core.Models;
using MusicLover.WebApp.Server.Persistent;
using System;

namespace MusicLover.WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171201205328_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(155);

                    b.Property<string>("LastName")
                        .HasMaxLength(155);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int?>("ProfilePhotoId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ProfilePhotoId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Attendance", b =>
                {
                    b.Property<int>("GigId");

                    b.Property<string>("AttendeeId");

                    b.Property<int?>("AttendeeId1");

                    b.HasKey("GigId", "AttendeeId");

                    b.HasIndex("AttendeeId1");

                    b.ToTable("AttendanceSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Following", b =>
                {
                    b.Property<string>("FolloweeId");

                    b.Property<string>("FollowerId");

                    b.Property<int?>("FolloweeId1");

                    b.Property<int?>("FollowerId1");

                    b.HasKey("FolloweeId", "FollowerId");

                    b.HasIndex("FolloweeId1");

                    b.HasIndex("FollowerId1");

                    b.ToTable("FollowingSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(155);

                    b.HasKey("Id");

                    b.ToTable("GenreSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Gig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArtistId")
                        .IsRequired();

                    b.Property<int?>("ArtistId1");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("GenreId");

                    b.Property<bool>("IsCancel");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ArtistId1");

                    b.HasIndex("GenreId");

                    b.ToTable("GigSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("GigId");

                    b.Property<int>("NotificationType");

                    b.Property<DateTime?>("OriginalDateTime");

                    b.Property<string>("OriginalVenue");

                    b.HasKey("Id");

                    b.HasIndex("GigId");

                    b.ToTable("NotificationSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName")
                        .HasMaxLength(155);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PhotoSet");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.UserNotification", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<int>("NotificationId");

                    b.Property<bool>("IsRead");

                    b.Property<int?>("UserId1");

                    b.HasKey("UserId", "NotificationId");

                    b.HasIndex("NotificationId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserNotificationSet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.ApplicationUser", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.Photo", "ProfilePhoto")
                        .WithMany()
                        .HasForeignKey("ProfilePhotoId");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Attendance", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeId1");

                    b.HasOne("MusicLover.WebApp.Server.Core.Models.Gig", "Gig")
                        .WithMany("Attendances")
                        .HasForeignKey("GigId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Following", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser", "Follower")
                        .WithMany("Followees")
                        .HasForeignKey("FollowerId1");
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Gig", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId1");

                    b.HasOne("MusicLover.WebApp.Server.Core.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.Notification", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.Gig", "Gig")
                        .WithMany()
                        .HasForeignKey("GigId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MusicLover.WebApp.Server.Core.Models.UserNotification", b =>
                {
                    b.HasOne("MusicLover.WebApp.Server.Core.Models.Notification", "Notification")
                        .WithMany()
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicLover.WebApp.Server.Core.Models.ApplicationUser", "User")
                        .WithMany("UserNotifications")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
