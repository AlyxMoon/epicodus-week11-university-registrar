﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Models;

namespace University.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210802175400_initial-models")]
    partial class initialmodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("University.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Label")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("course");
                });

            modelBuilder.Entity("University.Models.CourseStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_Course")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Course");

                    b.HasIndex("Id_Student");

                    b.ToTable("course_student");
                });

            modelBuilder.Entity("University.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("student");
                });

            modelBuilder.Entity("University.Models.CourseStudent", b =>
                {
                    b.HasOne("University.Models.Course", "Course")
                        .WithMany("JoinEntitiesStudent")
                        .HasForeignKey("Id_Course")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Models.Student", "Student")
                        .WithMany("JoinEntitiesCourse")
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("University.Models.Course", b =>
                {
                    b.Navigation("JoinEntitiesStudent");
                });

            modelBuilder.Entity("University.Models.Student", b =>
                {
                    b.Navigation("JoinEntitiesCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
