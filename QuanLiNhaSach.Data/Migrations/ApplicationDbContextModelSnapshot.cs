﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLiNhaSach.Data;

namespace QuanLiNhaSach.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Bill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDebit")
                        .HasColumnType("bit");

                    b.Property<string>("StaffId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("StaffId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BillDetail", b =>
                {
                    b.Property<string>("BillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("BillId", "BookId")
                        .HasName("PK__BillDeta__722CF04AE6C856BA");

                    b.HasIndex("BookId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("DatePublish")
                        .HasColumnType("date");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("new_first_exist")
                        .HasColumnType("int");

                    b.Property<int>("new_incurred_exist")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BookEntryTicket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateEntry")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("BookEntryTickets");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BookEntryTicketDetail", b =>
                {
                    b.Property<string>("BookEntryTicketId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("BookEntryTicketId", "BookId")
                        .HasName("PK__BookEntr__E356823B5A98F79F");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookEntryTicketDetails");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BookExistDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<int>("FirstExist")
                        .HasColumnType("int");

                    b.Property<int>("IncurredExist")
                        .HasColumnType("int");

                    b.Property<int>("LastExist")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeRecord")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookExistDetails");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.DebitDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<float>("FirstDebit")
                        .HasColumnType("real");

                    b.Property<float>("IncurredDebit")
                        .HasColumnType("real");

                    b.Property<float>("LastDebit")
                        .HasColumnType("real");

                    b.Property<DateTime>("TimeRecord")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("DebitDetails");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Receipt", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime");

                    b.Property<float>("Proceeds")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Rule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCheckRange")
                        .HasColumnType("bit");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UseThisRule")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<float>("new_first_debit")
                        .HasColumnType("real");

                    b.Property<float>("new_incurred_debit")
                        .HasColumnType("real");

                    b.Property<float>("new_last_debit")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("AppUser");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Bill", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.AppUser", "ApplicationUser")
                        .WithMany("BillApplicationUser")
                        .HasForeignKey("ApplicationUserId")
                        .HasConstraintName("FK_Bill_APPUSER");

                    b.HasOne("QuanLiNhaSach.Models.AppUser", "Staff")
                        .WithMany("BillStaff")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK_Bill_staff");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BillDetail", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.Bill", "Bill")
                        .WithMany("BillDetail")
                        .HasForeignKey("BillId")
                        .HasConstraintName("FK_BillDetail_Bill")
                        .IsRequired();

                    b.HasOne("QuanLiNhaSach.Models.Book", "Book")
                        .WithMany("BillDetail")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BillDetail_Book")
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Book", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Book_Category");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BookEntryTicketDetail", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.BookEntryTicket", "BookEntryTicket")
                        .WithMany("BookEntryTicketDetail")
                        .HasForeignKey("BookEntryTicketId")
                        .HasConstraintName("FK_BookEntryTicketDetail_BookEntryTicket")
                        .IsRequired();

                    b.HasOne("QuanLiNhaSach.Models.Book", "Book")
                        .WithMany("BookEntryTicketDetail")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookEntryTicketDetail_Book")
                        .IsRequired();

                    b.HasOne("QuanLiNhaSach.Models.Category", "Category")
                        .WithMany("BookEntryTicketDetail")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_BookEntryTicketDetail_Category");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.BookExistDetail", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.Book", "Book")
                        .WithMany("BookExistDetail")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookExistDetail_Book");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.DebitDetail", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.AppUser", "ApplicationUser")
                        .WithMany("DebitDetail")
                        .HasForeignKey("ApplicationUserId")
                        .HasConstraintName("FK_DebitDetail_AppUser");
                });

            modelBuilder.Entity("QuanLiNhaSach.Models.Receipt", b =>
                {
                    b.HasOne("QuanLiNhaSach.Models.AppUser", "ApplicationUser")
                        .WithMany("Receipt")
                        .HasForeignKey("ApplicationUserId")
                        .HasConstraintName("FK_Receipt_APPUSER")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
