﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIS_GOL.Infra.DataAccess;

namespace SIS_GOL.DataAccess.Migrations
{
    [DbContext(typeof(GOL_Context))]
    [Migration("20190606222402_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIS_GOL.Domain.Airplane", b =>
                {
                    b.Property<long>("IdAviao")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdAviao")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoAviao")
                        .HasColumnName("CodigoAviao")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnName("DataCriacao")
                        .HasColumnType("DATETIME");

                    b.Property<string>("ModeloAviao")
                        .HasColumnName("ModeloAviao")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(100);

                    b.Property<int>("QtdPassageiros")
                        .HasColumnName("QtdPassageiros")
                        .HasColumnType("INT");

                    b.HasKey("IdAviao");

                    b.ToTable("Airplane");
                });
#pragma warning restore 612, 618
        }
    }
}
