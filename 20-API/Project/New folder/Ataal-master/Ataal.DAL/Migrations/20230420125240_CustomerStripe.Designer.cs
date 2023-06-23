﻿// <auto-generated />
using System;
using Ataal.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ataal.DAL.Migrations
{
    [DbContext(typeof(AtaalContext))]
    [Migration("20230420125240_CustomerStripe")]
    partial class CustomerStripe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ataal.DAL.Data.Identity.AppUser", b =>
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
                        .IsRequired()
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

            modelBuilder.Entity("Ataal.DAL.Data.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cvc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frist_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NotificationCounter")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.KeyWords", b =>
                {
                    b.Property<int>("KeyWord_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyWord_ID"));

                    b.Property<string>("KeyWord_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Section_ID")
                        .HasColumnType("int");

                    b.HasKey("KeyWord_ID");

                    b.HasIndex("Section_ID");

                    b.ToTable("KeyWords");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("OfferSalary")
                        .HasColumnType("float");

                    b.Property<int>("problemId")
                        .HasColumnType("int");

                    b.Property<int>("technicalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("problemId");

                    b.HasIndex("technicalId")
                        .IsUnique();

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Problem", b =>
                {
                    b.Property<int>("Problem_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Problem_ID"));

                    b.Property<int?>("AcceptedOfferID")
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("KeyWord_ID")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Problem_Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Section_ID")
                        .HasColumnType("int");

                    b.Property<bool>("Solved")
                        .HasColumnType("bit");

                    b.Property<int?>("Technical_ID")
                        .HasColumnType("int");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("Problem_ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("KeyWord_ID");

                    b.HasIndex("Section_ID");

                    b.HasIndex("Technical_ID");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Rate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateId"));

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Rate_Value")
                        .HasColumnType("int");

                    b.Property<int>("Technical_ID")
                        .HasColumnType("int");

                    b.HasKey("RateId");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("Technical_ID");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Problem_ID")
                        .HasColumnType("int");

                    b.Property<int>("Technical_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Problem_ID");

                    b.HasIndex("Technical_ID");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Causes")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Review_ID")
                        .HasColumnType("int");

                    b.Property<int?>("TechnicalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Review_ID");

                    b.HasIndex("TechnicalId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Report_ID")
                        .HasColumnType("int");

                    b.Property<int>("Technical_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("Report_ID");

                    b.HasIndex("Technical_ID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Section", b =>
                {
                    b.Property<int>("Section_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Section_ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Section_ID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Technical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frist_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NotificationCounter")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Technicals");
                });

            modelBuilder.Entity("CustomerTechnical", b =>
                {
                    b.Property<int>("Blocked_Customers_IdId")
                        .HasColumnType("int");

                    b.Property<int>("Blocked_Technicals_IdId")
                        .HasColumnType("int");

                    b.HasKey("Blocked_Customers_IdId", "Blocked_Technicals_IdId");

                    b.HasIndex("Blocked_Technicals_IdId");

                    b.ToTable("CustomerTechnical");
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SectionTechnical", b =>
                {
                    b.Property<int>("SectionsSection_ID")
                        .HasColumnType("int");

                    b.Property<int>("TechnicalsId")
                        .HasColumnType("int");

                    b.HasKey("SectionsSection_ID", "TechnicalsId");

                    b.HasIndex("TechnicalsId");

                    b.ToTable("SectionTechnical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Admin", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", "AppUser")
                        .WithOne("Admin")
                        .HasForeignKey("Ataal.DAL.Data.Models.Admin", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Customer", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", "AppUser")
                        .WithOne("Customer")
                        .HasForeignKey("Ataal.DAL.Data.Models.Customer", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.KeyWords", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Section", "Section")
                        .WithMany("KeyWords")
                        .HasForeignKey("Section_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Offer", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Problem", "problem")
                        .WithMany("Offers")
                        .HasForeignKey("problemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", "technical")
                        .WithOne("offer")
                        .HasForeignKey("Ataal.DAL.Data.Models.Offer", "technicalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("problem");

                    b.Navigation("technical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Problem", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Customer", "Customer")
                        .WithMany("Problems")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.KeyWords", "KeyWord")
                        .WithMany("Problems")
                        .HasForeignKey("KeyWord_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Section", "Section")
                        .WithMany("Problems")
                        .HasForeignKey("Section_ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", "Technical")
                        .WithMany("Problems_Solved")
                        .HasForeignKey("Technical_ID");

                    b.Navigation("Customer");

                    b.Navigation("KeyWord");

                    b.Navigation("Section");

                    b.Navigation("Technical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Rate", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Customer", "Customer")
                        .WithMany("Rates")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", "Technical")
                        .WithMany("CustomersRate")
                        .HasForeignKey("Technical_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Technical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Recommendation", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Problem", "problem")
                        .WithMany("Recommendations")
                        .HasForeignKey("Problem_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", "Technical")
                        .WithMany("Recommendations")
                        .HasForeignKey("Technical_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Technical");

                    b.Navigation("problem");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Report", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("Review_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", null)
                        .WithMany("Reports")
                        .HasForeignKey("TechnicalId");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Review", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Report", "Report")
                        .WithMany()
                        .HasForeignKey("Report_ID");

                    b.HasOne("Ataal.DAL.Data.Models.Technical", "Technical")
                        .WithMany("Reviews")
                        .HasForeignKey("Technical_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Report");

                    b.Navigation("Technical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Technical", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", "AppUser")
                        .WithOne("Technical")
                        .HasForeignKey("Ataal.DAL.Data.Models.Technical", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("CustomerTechnical", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("Blocked_Customers_IdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", null)
                        .WithMany()
                        .HasForeignKey("Blocked_Technicals_IdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", null)
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

                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SectionTechnical", b =>
                {
                    b.HasOne("Ataal.DAL.Data.Models.Section", null)
                        .WithMany()
                        .HasForeignKey("SectionsSection_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ataal.DAL.Data.Models.Technical", null)
                        .WithMany()
                        .HasForeignKey("TechnicalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ataal.DAL.Data.Identity.AppUser", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Customer");

                    b.Navigation("Technical");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Customer", b =>
                {
                    b.Navigation("Problems");

                    b.Navigation("Rates");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.KeyWords", b =>
                {
                    b.Navigation("Problems");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Problem", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("Recommendations");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Section", b =>
                {
                    b.Navigation("KeyWords");

                    b.Navigation("Problems");
                });

            modelBuilder.Entity("Ataal.DAL.Data.Models.Technical", b =>
                {
                    b.Navigation("CustomersRate");

                    b.Navigation("Problems_Solved");

                    b.Navigation("Recommendations");

                    b.Navigation("Reports");

                    b.Navigation("Reviews");

                    b.Navigation("offer");
                });
#pragma warning restore 612, 618
        }
    }
}
