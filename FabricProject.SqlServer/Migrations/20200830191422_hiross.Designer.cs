﻿// <auto-generated />
using System;
using FabricProject.DContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FabricProject.SqlServer.Migrations
{
    [DbContext(typeof(FabricProjectDbContext))]
    [Migration("20200830191422_hiross")]
    partial class hiross
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FabricProject.Models.Models.Cloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cloths");
                });

            modelBuilder.Entity("FabricProject.Models.Models.ClothMaterail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClothId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int>("MaterailId");

                    b.HasKey("Id");

                    b.HasIndex("ClothId");

                    b.HasIndex("MaterailId");

                    b.ToTable("ClothMaterails");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Email");

                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClothId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("OldColor");

                    b.Property<int>("PercentCotton");

                    b.Property<int>("PercentPolister");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ClothId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorAmount");

                    b.Property<int>("ColorId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CustomerOrderId");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<bool>("IsDeliver");

                    b.Property<bool>("IsOut");

                    b.Property<int>("OldLenght");

                    b.Property<int>("PartialWeghit");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("CustomerOrderId");

                    b.ToTable("OrderDetailCustomers");
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrderDetailsMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmountWater");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CustomerOrderDetailId");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int?>("MachineId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerOrderDetailId");

                    b.HasIndex("MachineId");

                    b.ToTable("CustomerOrderDetailsMachine");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Deliver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<bool>("IsDeliver");

                    b.Property<int>("Length");

                    b.Property<int>("NewLength");

                    b.Property<int>("OrderDetailCustomerId");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailCustomerId");

                    b.ToTable("Delivers");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Lab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothId");

                    b.Property<int?>("ColorId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int>("SuccuessPercent");

                    b.HasKey("Id");

                    b.HasIndex("ClothId");

                    b.HasIndex("ColorId");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int>("MachineType");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("FabricProject.Models.Models.MachineOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int>("MachineId");

                    b.Property<int>("OrderDetailId");

                    b.Property<int>("WaterAmount");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("MachineOrders");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Materail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("FabricProject.Models.Models.MaterialOrderDetailCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("ClothMaterialId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime>("EditedAt");

                    b.Property<int?>("OrderDetailCustomerId");

                    b.HasKey("Id");

                    b.HasIndex("ClothMaterialId");

                    b.HasIndex("OrderDetailCustomerId");

                    b.ToTable("MaterialOrderDetailCustomers");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NameAr");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = 1, ConcurrencyStamp = "82582d95-30d7-404b-a7b8-70304b9af9ad", Name = "Admin", NameAr = "مدير عام", NormalizedName = "ADMIN" },
                        new { Id = 2, ConcurrencyStamp = "9adb409c-77cf-475a-bfbc-8f7ed48d257b", Name = "Receiving", NameAr = "أمين مستودع الاستلام", NormalizedName = "RECEIVING" },
                        new { Id = 3, ConcurrencyStamp = "e94a6b8b-e79d-48cc-866a-87d1a531e702", Name = "Delivery", NameAr = "مسؤول التسليم", NormalizedName = "DELIVERY" },
                        new { Id = 4, ConcurrencyStamp = "350de13e-2fe3-45b4-b2e8-b1c640f84f7d", Name = "Machine", NameAr = "مسؤول الماكينات", NormalizedName = "MACHINE" },
                        new { Id = 5, ConcurrencyStamp = "de29662a-2a26-4560-b9d1-0f9381fadd2c", Name = "Laboratory", NameAr = "مسؤول المخبر", NormalizedName = "LABORATORY" }
                    );
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("AccountDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<int>("Id");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAlternateKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<int>("Id");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.HasAlternateKey("Id");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FabricProject.Models.Models.ClothMaterail", b =>
                {
                    b.HasOne("FabricProject.Models.Models.Cloth", "Cloth")
                        .WithMany("ClothMaterails")
                        .HasForeignKey("ClothId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FabricProject.Models.Models.Materail", "Material")
                        .WithMany("ClothMaterails")
                        .HasForeignKey("MaterailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrder", b =>
                {
                    b.HasOne("FabricProject.Models.Models.Cloth", "Cloth")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("ClothId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FabricProject.Models.Models.Customer", "Customer")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrderDetail", b =>
                {
                    b.HasOne("FabricProject.Models.Models.Color", "Color")
                        .WithMany("OrderDetailCustomers")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FabricProject.Models.Models.CustomerOrder", "CustomerOrder")
                        .WithMany("OrderDetailCustomers")
                        .HasForeignKey("CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Models.CustomerOrderDetailsMachine", b =>
                {
                    b.HasOne("FabricProject.Models.Models.CustomerOrderDetail", "CustomerOrderDetail")
                        .WithMany("CustomerOrderDetailsMachine")
                        .HasForeignKey("CustomerOrderDetailId");

                    b.HasOne("FabricProject.Models.Models.Machine", "Machine")
                        .WithMany("CustomerOrderDetailsMachine")
                        .HasForeignKey("MachineId");
                });

            modelBuilder.Entity("FabricProject.Models.Models.Deliver", b =>
                {
                    b.HasOne("FabricProject.Models.Models.CustomerOrderDetail", "OrderDetail")
                        .WithMany("Deliver")
                        .HasForeignKey("OrderDetailCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Models.Lab", b =>
                {
                    b.HasOne("FabricProject.Models.Models.Cloth", "Cloth")
                        .WithMany("LabCloth")
                        .HasForeignKey("ClothId");

                    b.HasOne("FabricProject.Models.Models.Color", "NewColor")
                        .WithMany("Labs")
                        .HasForeignKey("ColorId");
                });

            modelBuilder.Entity("FabricProject.Models.Models.MachineOrder", b =>
                {
                    b.HasOne("FabricProject.Models.Models.Machine", "Machine")
                        .WithMany("MachineOrders")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FabricProject.Models.Models.CustomerOrderDetail", "OrderDetailCustomer")
                        .WithMany("MachineOrders")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Models.MaterialOrderDetailCustomer", b =>
                {
                    b.HasOne("FabricProject.Models.Models.ClothMaterail", "ClothMaterial")
                        .WithMany("MaterialOrderDetailCustomers")
                        .HasForeignKey("ClothMaterialId");

                    b.HasOne("FabricProject.Models.Models.CustomerOrderDetail", "OrderDetailCustomer")
                        .WithMany("MaterailOrderDetailCustoemrs")
                        .HasForeignKey("OrderDetailCustomerId");
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbRoleClaim", b =>
                {
                    b.HasOne("FabricProject.Models.Security.FbRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserClaim", b =>
                {
                    b.HasOne("FabricProject.Models.Security.FbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserLogin", b =>
                {
                    b.HasOne("FabricProject.Models.Security.FbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserRole", b =>
                {
                    b.HasOne("FabricProject.Models.Security.FbRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FabricProject.Models.Security.FbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FabricProject.Models.Security.FbUserToken", b =>
                {
                    b.HasOne("FabricProject.Models.Security.FbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
