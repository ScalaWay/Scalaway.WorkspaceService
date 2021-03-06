// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkspaceService.EntityFrameworkCore;

#nullable disable

namespace WorkspaceService.EntityFrameworkCore.Migrations.Authorization.Development
{
    [DbContext(typeof(WorkspaceDouanierDbContext))]
    partial class WorkspaceDouanierDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionGrantModel", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsGranted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Origin")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectType")
                        .HasColumnType("TEXT");

                    b.HasKey("PermissionId", "SubjectId", "ResourceId");

                    b.ToTable("PermissionGrants", (string)null);
                });

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionGroupModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("PermissionGroups", (string)null);
                });

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PermissionGroupId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("PermissionGroupId");

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionGrantModel", b =>
                {
                    b.HasOne("Douanier.EntityFrameworkCore.Permissions.Models.PermissionModel", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionModel", b =>
                {
                    b.HasOne("Douanier.EntityFrameworkCore.Permissions.Models.PermissionGroupModel", "PermissionGroup")
                        .WithMany("Permissions")
                        .HasForeignKey("PermissionGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionGroup");
                });

            modelBuilder.Entity("Douanier.EntityFrameworkCore.Permissions.Models.PermissionGroupModel", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
