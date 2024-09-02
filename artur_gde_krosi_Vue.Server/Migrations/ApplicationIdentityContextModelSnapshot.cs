﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using artur_gde_krosi_Vue.Server.Models.ProjecktSetings;

#nullable disable

namespace artur_gde_krosi_Vue.Server.Migrations
{
    [DbContext(typeof(ApplicationIdentityContext))]
    partial class ApplicationIdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        });
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

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", b =>
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

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("sendingMail")
                        .HasColumnType("bit");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Brend", b =>
                {
                    b.Property<string>("BrendId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrendId");

                    b.ToTable("Brends", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProduct", b =>
                {
                    b.Property<string>("CharacteristicProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacteristicProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CharacteristicProducts", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProductValue", b =>
                {
                    b.Property<string>("CharacteristicProductValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CharacteristicProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacteristicProductValueId");

                    b.HasIndex("CharacteristicProductId");

                    b.ToTable("CharacteristicProductValues", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Image", b =>
                {
                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ImageVariant", b =>
                {
                    b.Property<string>("ImageVariantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VariantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageVariantId");

                    b.HasIndex("VariantId");

                    b.ToTable("ImageVariants", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ModelKrosovock", b =>
                {
                    b.Property<string>("ModelKrosovockId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BrendID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelKrosovockId");

                    b.HasIndex("BrendID");

                    b.ToTable("ModelKrosovocks", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModelKrosovockId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("views")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ModelKrosovockId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ShoppingСart", b =>
                {
                    b.Property<string>("ShoppingСartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VariantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("ShoppingСartId");

                    b.HasIndex("UserId");

                    b.HasIndex("VariantId");

                    b.ToTable("ShoppingСarts", (string)null);
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Variant", b =>
                {
                    b.Property<string>("VariantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("externalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prise")
                        .HasColumnType("float");

                    b.Property<int>("quantityInStock")
                        .HasColumnType("int");

                    b.Property<double>("shoeSize")
                        .HasColumnType("float");

                    b.HasKey("VariantId");

                    b.HasIndex("ProductId");

                    b.ToTable("Variants", (string)null);
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
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", null)
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

                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProduct", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Product", "Product")
                        .WithMany("CharacteristicProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProductValue", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProduct", "CharacteristicProduct")
                        .WithMany("CharacteristicProductValues")
                        .HasForeignKey("CharacteristicProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharacteristicProduct");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Image", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ImageVariant", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Variant", "Variant")
                        .WithMany("ImageVariants")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ModelKrosovock", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Brend", "Brend")
                        .WithMany("ModelKrosovocks")
                        .HasForeignKey("BrendID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brend");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Product", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ModelKrosovock", "ModelKrosovock")
                        .WithMany("Products")
                        .HasForeignKey("ModelKrosovockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelKrosovock");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ShoppingСart", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Variant", "Variant")
                        .WithMany("ShoppingСarts")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Variant", b =>
                {
                    b.HasOne("artur_gde_krosi_Vue.Server.Models.BdModel.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Brend", b =>
                {
                    b.Navigation("ModelKrosovocks");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.CharacteristicProduct", b =>
                {
                    b.Navigation("CharacteristicProductValues");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.ModelKrosovock", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Product", b =>
                {
                    b.Navigation("CharacteristicProducts");

                    b.Navigation("Images");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("artur_gde_krosi_Vue.Server.Models.BdModel.Variant", b =>
                {
                    b.Navigation("ImageVariants");

                    b.Navigation("ShoppingСarts");
                });
#pragma warning restore 612, 618
        }
    }
}
