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
    [Migration("20231120200226_Add-entity-user")]
    partial class Addentityuser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.MedicalRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasColumnType("varchar(4000)")
                        .HasColumnName("Annotation");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DeletedDate");

                    b.Property<ulong>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<ulong>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecord");
                });

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.Patient", b =>
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

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CellPhone");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("City");

                    b.Property<string>("Complement")
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Name");

                    b.Property<long>("Number")
                        .HasColumnType("bigint")
                        .HasColumnName("Number");

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

                    b.ToTable("Patient");
                });

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

                    b.Property<string>("Name")
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

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.ServiceStatus", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("ServiceStatus");
                });

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.Speciality", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Speciality");
                });

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.User", b =>
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

                    b.Property<ulong>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<ulong>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("LastPassword")
                        .HasColumnType("varchar(65)")
                        .HasColumnName("LastPassword");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(65)")
                        .HasColumnName("Password");

                    b.Property<long>("PeopleId")
                        .HasColumnType("bigint")
                        .HasColumnName("PeopleId");

                    b.Property<string>("Token")
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Token");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.ToTable("User");
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

            modelBuilder.Entity("MbaImpacta.GrupoVidaBrasil.Core.Models.User", b =>
                {
                    b.HasOne("MbaImpacta.GrupoVidaBrasil.Core.Models.People", "People")
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
