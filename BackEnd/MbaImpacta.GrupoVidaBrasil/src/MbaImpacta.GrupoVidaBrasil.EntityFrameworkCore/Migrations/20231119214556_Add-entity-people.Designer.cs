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
    [Migration("20231119214556_Add-entity-people")]
    partial class Addentitypeople
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.People", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("BirthDate");

                    b.Property<string>("CRM")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CRM");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CellPhone");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("City");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Complement");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("District");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Email");

                    b.Property<ulong>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(350)")
                        .HasColumnName("Name");

                    b.Property<long>("Number")
                        .HasColumnType("bigint")
                        .HasColumnName("Number");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint")
                        .HasColumnName("ProfileId");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasColumnName("State");

                    b.Property<string>("Telephone")
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Telephone");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("People");
                });

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

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.People", b =>
                {
                    b.HasOne("MbaImpacta.GrupoVidaBrasil.Core.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
