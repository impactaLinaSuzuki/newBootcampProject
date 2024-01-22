﻿// <auto-generated />
using System;
using MbaImpacta.GrupoVidaBrasil.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MbaImpacta.GrupoVidaBrasil.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(GrupoVidaBrasilDbContext))]
    [Migration("20231119214518_Add-entity-profile")]
    partial class Addentityprofile
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.Profile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DeletedDate");

                    b.Property<ulong>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<ulong>("IsInternal")
                        .HasColumnType("bit")
                        .HasColumnName("IsInternal");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}