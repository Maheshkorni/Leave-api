﻿// <auto-generated />
using System;
using LmsApi.DataAccessLayer_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LmsApi.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    [Migration("20220723074803_initLMS")]
    partial class initLMS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LmsApi.Modals.EmployeeDbModal", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("CasualLeaves")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EarnedLeaves")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaveBalance")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("MaternityLeaves")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee_table");
                });

            modelBuilder.Entity("LmsApi.Modals.LeaveDbModal", b =>
                {
                    b.Property<int>("leaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("appliedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("leaveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("managerComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("leaveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leave_Table");
                });

            modelBuilder.Entity("LmsApi.Modals.LeaveDbModal", b =>
                {
                    b.HasOne("LmsApi.Modals.EmployeeDbModal", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}