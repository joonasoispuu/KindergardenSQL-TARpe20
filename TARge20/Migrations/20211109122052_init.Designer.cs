﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20211109122052_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChildGroup", b =>
                {
                    b.Property<int>("ChildrenChildId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenChildId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("ChildGroup");
                });

            modelBuilder.Entity("ChildParent", b =>
                {
                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<string>("ParentFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ChildId", "ParentFirstName");

                    b.HasIndex("ParentFirstName");

                    b.ToTable("ChildParent");
                });

            modelBuilder.Entity("EmployeesGroup", b =>
                {
                    b.Property<string>("EmployeesFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesFirstName", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("EmployeesGroup");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Absences", b =>
                {
                    b.Property<int>("AbsenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChildId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfAbsence")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeesFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbsenceId");

                    b.HasIndex("ChildId");

                    b.HasIndex("EmployeesFirstName");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.Property<int>("ChildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbsenceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChildId");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employees", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KitchenId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStart")
                        .HasColumnType("datetime2");

                    b.HasKey("FirstName");

                    b.HasIndex("KitchenId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeGroup")
                        .HasColumnType("int");

                    b.Property<int>("ChildrenAmount")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("TARge20.Core.Domain.GroupHistory", b =>
                {
                    b.Property<int>("GroupHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ChildId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeesFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("datetime2");

                    b.HasKey("GroupHistoryId");

                    b.HasIndex("ChildId");

                    b.HasIndex("EmployeesFirstName");

                    b.ToTable("GroupHistory");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Job", b =>
                {
                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeesFirstName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("JobType");

                    b.HasIndex("EmployeesFirstName");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kitchen", b =>
                {
                    b.Property<int>("KitchenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("KitchenId");

                    b.HasIndex("GroupId");

                    b.ToTable("Kitchen");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatesofMenu")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dishes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KitchenId")
                        .HasColumnType("int");

                    b.Property<int>("Portions")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("KitchenId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Parent", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirstName");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("ChildGroup", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TARge20.Core.Domain.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChildParent", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TARge20.Core.Domain.Parent", null)
                        .WithMany()
                        .HasForeignKey("ParentFirstName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeesGroup", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employees", null)
                        .WithMany()
                        .HasForeignKey("EmployeesFirstName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TARge20.Core.Domain.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TARge20.Core.Domain.Absences", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", null)
                        .WithMany("Absence")
                        .HasForeignKey("ChildId");

                    b.HasOne("TARge20.Core.Domain.Employees", null)
                        .WithMany("Absence")
                        .HasForeignKey("EmployeesFirstName");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employees", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Kitchen", null)
                        .WithMany("Employees")
                        .HasForeignKey("KitchenId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.GroupHistory", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", null)
                        .WithMany("groupHistory")
                        .HasForeignKey("ChildId");

                    b.HasOne("TARge20.Core.Domain.Employees", null)
                        .WithMany("GroupHistory")
                        .HasForeignKey("EmployeesFirstName");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Job", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employees", null)
                        .WithMany("Job")
                        .HasForeignKey("EmployeesFirstName");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kitchen", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", null)
                        .WithMany("Kitchen")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Menu", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Kitchen", null)
                        .WithMany("Menu")
                        .HasForeignKey("KitchenId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.Navigation("Absence");

                    b.Navigation("groupHistory");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employees", b =>
                {
                    b.Navigation("Absence");

                    b.Navigation("GroupHistory");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.Navigation("Kitchen");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kitchen", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
