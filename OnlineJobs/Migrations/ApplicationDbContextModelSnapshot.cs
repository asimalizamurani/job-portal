﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineJobs.Data;

#nullable disable

namespace OnlineJobs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineJobs.Models.Applicant", b =>
                {
                    b.Property<int>("ApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicantId"));

                    b.Property<DateTime>("AppliedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("AttachedVacancyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicantId");

                    b.HasIndex("AttachedVacancyId");

                    b.ToTable("Applicants", (string)null);
                });

            modelBuilder.Entity("OnlineJobs.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("OnlineJobs.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("OnlineJobs.Models.Vacancy", b =>
                {
                    b.Property<int>("VacancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacancyId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserUserId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionsAvailable")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacancyId");

                    b.HasIndex("CreatedByUserUserId");

                    b.ToTable("Vacancies", (string)null);
                });

            modelBuilder.Entity("OnlineJobs.Models.Applicant", b =>
                {
                    b.HasOne("OnlineJobs.Models.Vacancy", "AttachedVacancy")
                        .WithMany()
                        .HasForeignKey("AttachedVacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttachedVacancy");
                });

            modelBuilder.Entity("OnlineJobs.Models.Vacancy", b =>
                {
                    b.HasOne("OnlineJobs.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
