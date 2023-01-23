﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSClinica.Data;

namespace WSClinica.Migrations
{
    [DbContext(typeof(DbClinicaContext))]
    [Migration("20230123185105_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSClinica.Models.Clinica", b =>
                {
                    b.Property<int>("ClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime>("FechaInicioActividaes")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ClinicaId");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("WSClinica.Models.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("EspecialidadId");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("WSClinica.Models.Habitacion", b =>
                {
                    b.Property<int>("HabitacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("HabitacionId");

                    b.HasIndex("ClinicaId");

                    b.ToTable("Habitacion");
                });

            modelBuilder.Entity("WSClinica.Models.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("MedicoId");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("WSClinica.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("PacienteId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("WSClinica.Models.Habitacion", b =>
                {
                    b.HasOne("WSClinica.Models.Clinica", "Clinica")
                        .WithMany("Habitaciones")
                        .HasForeignKey("ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WSClinica.Models.Medico", b =>
                {
                    b.HasOne("WSClinica.Models.Especialidad", "Especialidad")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WSClinica.Models.Paciente", b =>
                {
                    b.HasOne("WSClinica.Models.Medico", "Medico")
                        .WithMany("Pacientes")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
