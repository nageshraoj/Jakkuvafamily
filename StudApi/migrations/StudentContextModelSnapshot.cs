﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudDB.entities;

namespace StudApi.migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("StudDB.models.ExamDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExamName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExamDetails");
                });

            modelBuilder.Entity("StudDB.models.Marks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExamDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExmaName")
                        .HasColumnType("TEXT");

                    b.Property<int>("marks")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExamDetailsId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("StudDB.models.StudentFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PaidOn")
                        .HasColumnType("Date");

                    b.Property<int>("feepaid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("studentFee");
                });

            modelBuilder.Entity("StudDB.models.StudentMarks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("examId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("examId");

                    b.ToTable("studentMarks");
                });

            modelBuilder.Entity("StudDB.models.students", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MarksId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("FeeId");

                    b.HasIndex("MarksId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("StudDB.models.Marks", b =>
                {
                    b.HasOne("StudDB.models.ExamDetails", null)
                        .WithMany("marks")
                        .HasForeignKey("ExamDetailsId");
                });

            modelBuilder.Entity("StudDB.models.StudentMarks", b =>
                {
                    b.HasOne("StudDB.models.ExamDetails", "exam")
                        .WithMany()
                        .HasForeignKey("examId");
                });

            modelBuilder.Entity("StudDB.models.students", b =>
                {
                    b.HasOne("StudDB.models.StudentFee", "Fee")
                        .WithMany()
                        .HasForeignKey("FeeId");

                    b.HasOne("StudDB.models.StudentMarks", "Marks")
                        .WithMany()
                        .HasForeignKey("MarksId");
                });
#pragma warning restore 612, 618
        }
    }
}
