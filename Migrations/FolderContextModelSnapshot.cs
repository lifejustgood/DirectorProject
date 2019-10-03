﻿// <auto-generated />
using System;
using DirectoryProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DirectoryProject.Migrations
{
    [DbContext(typeof(FolderContext))]
    partial class FolderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DirectoryProject.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FolderRootId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FolderRootId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("DirectoryProject.Models.Folder", b =>
                {
                    b.HasOne("DirectoryProject.Models.Folder", "FolderRoot")
                        .WithMany()
                        .HasForeignKey("FolderRootId");
                });
#pragma warning restore 612, 618
        }
    }
}
