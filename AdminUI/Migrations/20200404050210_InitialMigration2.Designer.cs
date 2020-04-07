﻿// <auto-generated />
using System;
using AdminUI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminUI.Migrations
{
    [DbContext(typeof(TimesheetContext))]
    [Migration("20200404050210_InitialMigration2")]
    partial class InitialMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminUI.Models.Timesheet", b =>
                {
                    b.Property<int>("TimesheetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CMOrg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientPrime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ClientSignature")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ClientSigned")
                        .HasColumnType("datetime2");

                    b.Property<string>("Freq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Hours")
                        .HasColumnType("float");

                    b.Property<string>("ModCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgressNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProviderSignature")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ProviderSigned")
                        .HasColumnType("datetime2");

                    b.Property<string>("SCPAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceGoal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Submitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimesheetID");

                    b.ToTable("Timesheet");
                });
#pragma warning restore 612, 618
        }
    }
}
