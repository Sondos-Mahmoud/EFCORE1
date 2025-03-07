﻿// <auto-generated />
using System;
using EFCORE1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCORE1.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20250307185117_Fix2")]
    partial class Fix2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE1.Entities.Course", b =>
                {
                    b.Property<int>("Course_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Course_ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("EFCORE1.Entities.CourseInst", b =>
                {
                    b.Property<int>("Inst_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Inst_ID"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Evaluate")
                        .HasColumnType("int");

                    b.HasKey("Inst_ID");

                    b.ToTable("CourseInst");
                });

            modelBuilder.Entity("EFCORE1.Entities.Department", b =>
                {
                    b.Property<int>("Dept_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_ID"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inst_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Dept_ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EFCORE1.Entities.Instructor", b =>
                {
                    b.Property<int>("Inst_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Inst_ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bouns")
                        .HasColumnType("int");

                    b.Property<int>("houre_rate")
                        .HasColumnType("int");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Inst_ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("EFCORE1.Entities.StudCourse", b =>
                {
                    b.Property<int>("Stud_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Stud_ID"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Stud_ID");

                    b.ToTable("StudCourse");
                });

            modelBuilder.Entity("EFCORE1.Entities.Student", b =>
                {
                    b.Property<int>("Stud_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Stud_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("F_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stud_ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EFCORE1.Entities.Topic", b =>
                {
                    b.Property<int>("Topic_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Topic_ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Topic_ID");

                    b.ToTable("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}
