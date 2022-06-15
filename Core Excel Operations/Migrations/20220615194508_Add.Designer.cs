﻿// <auto-generated />
using Core_Excel_Operations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core_Excel_Operations.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220615194508_Add")]
    partial class Add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core_Excel_Operations.Models.PersonalViewModel", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonalMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalSurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalID");

                    b.ToTable("Personal");
                });
#pragma warning restore 612, 618
        }
    }
}
