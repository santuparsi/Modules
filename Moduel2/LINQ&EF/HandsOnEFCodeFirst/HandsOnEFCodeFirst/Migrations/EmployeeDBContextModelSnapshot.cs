﻿// <auto-generated />
using System;
using HandsOnEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandsOnEFCodeFirst.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    partial class EmployeeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desig")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Designation");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("JoinDate")
                        .HasColumnType("Date");

                    b.Property<string>("ProjectCode")
                        .HasMaxLength(5)
                        .HasColumnType("Char(5)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.HasIndex("ProjectCode");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Project", b =>
                {
                    b.Property<string>("ProjectCode")
                        .HasMaxLength(5)
                        .HasColumnType("Char(5)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ProjectCode");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Employee", b =>
                {
                    b.HasOne("HandsOnEFCodeFirst.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectCode");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}
