﻿// <auto-generated />
using System;
using Healthy_Clinic_Manha_Edu.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Healthy_Clinic_Manha_Edu.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231004133216_Healthy_Clinic_Manha_Edu")]
    partial class Healthy_Clinic_Manha_Edu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Administrador", b =>
                {
                    b.Property<Guid>("IdAdministrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdAdministrador");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Agendamento", b =>
                {
                    b.Property<Guid>("IdAgendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataConsulta")
                        .IsRequired()
                        .HasColumnType("DATE");

                    b.Property<TimeSpan?>("HorarioConsulta")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.HasKey("IdAgendamento");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Clinica", b =>
                {
                    b.Property<Guid>("IdClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<TimeSpan?>("HorarioAbertura")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.Property<TimeSpan?>("HorarioFechamento")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdClinica");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Comentario", b =>
                {
                    b.Property<Guid>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescricaoComentario")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMedico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentario");

                    b.HasIndex("IdConsulta");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Consulta", b =>
                {
                    b.Property<Guid>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdAgendamento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMedico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProntuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Idpaciente")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdConsulta");

                    b.HasIndex("IdAgendamento");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdProntuario");

                    b.HasIndex("Idpaciente");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Especialidade", b =>
                {
                    b.Property<Guid>("IdEspecialidades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeEspecialidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("IdEspecialidades");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Medico", b =>
                {
                    b.Property<Guid>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<Guid>("IdClinica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEspecialidades")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTiposUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdMedico");

                    b.HasIndex("CRM")
                        .IsUnique();

                    b.HasIndex("IdClinica");

                    b.HasIndex("IdEspecialidades");

                    b.HasIndex("IdTiposUsuario");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Paciente", b =>
                {
                    b.Property<Guid>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdPaciente");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Prontuario", b =>
                {
                    b.Property<Guid>("IdProntuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescricaoConsulta")
                        .HasColumnType("TEXT");

                    b.HasKey("IdProntuario");

                    b.ToTable("Prontuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.TiposUsuario", b =>
                {
                    b.Property<Guid>("IdTiposUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("IdTiposUsuario");

                    b.ToTable("TiposUsuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("IdTiposUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdTiposUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Administrador", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Comentario", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Consulta", "consulta")
                        .WithMany()
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("consulta");

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Consulta", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Agendamento", "agendamento")
                        .WithMany()
                        .HasForeignKey("IdAgendamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Medico", "medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Prontuario", "prontuario")
                        .WithMany()
                        .HasForeignKey("IdProntuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("Idpaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("agendamento");

                    b.Navigation("medico");

                    b.Navigation("paciente");

                    b.Navigation("prontuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Medico", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Clinica", "Clinica")
                        .WithMany()
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Especialidade", "Especialidades")
                        .WithMany()
                        .HasForeignKey("IdEspecialidades")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.TiposUsuario", "TiposUsuario")
                        .WithMany()
                        .HasForeignKey("IdTiposUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Especialidades");

                    b.Navigation("TiposUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Paciente", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Healthy_Clinic_Manha_Edu.Domains.Usuario", b =>
                {
                    b.HasOne("Healthy_Clinic_Manha_Edu.Domains.TiposUsuario", "TiposUsuario")
                        .WithMany()
                        .HasForeignKey("IdTiposUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TiposUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}