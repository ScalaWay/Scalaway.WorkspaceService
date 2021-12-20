﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkspaceService.EntityFrameworkCore;

#nullable disable

namespace WorkspaceService.EntityFrameworkCore.Migrations.Workspaces.Development
{
    [DbContext(typeof(WorkspaceDbContext))]
    [Migration("20211220031801_Workspace")]
    partial class Workspace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("WorkspaceService.Domain.Models.Compartments.Compartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("WorkspaceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Compartments", (string)null);
                });

            modelBuilder.Entity("WorkspaceService.Domain.Models.Workspaces.Workspace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LastModifierId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Workspaces", (string)null);
                });

            modelBuilder.Entity("WorkspaceService.Domain.Models.Compartments.Compartment", b =>
                {
                    b.HasOne("WorkspaceService.Domain.Models.Workspaces.Workspace", "Workspace")
                        .WithMany("Compartments")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("WorkspaceService.Domain.Models.Workspaces.Workspace", b =>
                {
                    b.Navigation("Compartments");
                });
#pragma warning restore 612, 618
        }
    }
}
