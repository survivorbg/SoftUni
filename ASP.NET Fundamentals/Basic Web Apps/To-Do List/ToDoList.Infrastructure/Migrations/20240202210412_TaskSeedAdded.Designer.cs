﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoList.Infrastructure.Data;

#nullable disable

namespace ToDoList.Infrastructure.Migrations
{
    [DbContext(typeof(ToDoListDbContext))]
    [Migration("20240202210412_TaskSeedAdded")]
    partial class TaskSeedAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoList.Infrastructure.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id of the task");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2")
                        .HasComment("Task deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasComment("Task description");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit")
                        .HasComment("Is the task completed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Task title");

                    b.HasKey("Id");

                    b.ToTable("Tasks", t =>
                        {
                            t.HasComment("Pending Task");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deadline = new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1167),
                            Description = "To write something interesting.",
                            IsCompleted = false,
                            Title = "Write first task"
                        },
                        new
                        {
                            Id = 2,
                            Deadline = new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1210),
                            Description = "To write something interesting.",
                            IsCompleted = false,
                            Title = "Write second task"
                        },
                        new
                        {
                            Id = 3,
                            Deadline = new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1212),
                            Description = "To write something interesting.",
                            IsCompleted = false,
                            Title = "Write third task"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
