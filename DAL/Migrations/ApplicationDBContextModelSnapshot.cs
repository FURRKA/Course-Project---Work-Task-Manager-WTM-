﻿// <auto-generated />
using System;
using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WorkTaskId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkTaskId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DAL.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DAL.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DAL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Entities.UserProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProperties");
                });

            modelBuilder.Entity("DAL.Entities.WorkTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ProjectTag", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("integer");

                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.HasKey("ProjectsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ProjectTag");
                });

            modelBuilder.Entity("ProjectUserProperty", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("ProjectsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProjectUserProperty");
                });

            modelBuilder.Entity("ProjectWorkTask", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("integer");

                    b.Property<int>("TasksId")
                        .HasColumnType("integer");

                    b.HasKey("ProjectsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("ProjectWorkTask");
                });

            modelBuilder.Entity("TagWorkTask", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.Property<int>("TasksId")
                        .HasColumnType("integer");

                    b.HasKey("TagsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("TagWorkTask");
                });

            modelBuilder.Entity("UserWorkTask", b =>
                {
                    b.Property<int>("TasksId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("TasksId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("UserWorkTask");
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.WorkTask", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("WorkTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Project", b =>
                {
                    b.HasOne("DAL.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany("Projects")
                        .HasForeignKey("UserId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.HasOne("DAL.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DAL.Entities.UserProperty", b =>
                {
                    b.HasOne("DAL.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectTag", b =>
                {
                    b.HasOne("DAL.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectUserProperty", b =>
                {
                    b.HasOne("DAL.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserProperty", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectWorkTask", b =>
                {
                    b.HasOne("DAL.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.WorkTask", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TagWorkTask", b =>
                {
                    b.HasOne("DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.WorkTask", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserWorkTask", b =>
                {
                    b.HasOne("DAL.Entities.WorkTask", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("DAL.Entities.WorkTask", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
