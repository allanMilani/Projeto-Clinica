﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_Cliínica.Data;

namespace Projeto_Cliínica.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211204170327_correcao_tabela_agendamento2")]
    partial class correcao_tabela_agendamento2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto_Cliínica.Models.Agendamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnotacoesMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCancelamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraConsulta")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("HoraFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("bit");

                    b.Property<int?>("MedicoID")
                        .HasColumnType("int");

                    b.Property<string>("MotivoCancelamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacienteID")
                        .HasColumnType("int");

                    b.Property<int?>("QuemCancelouID")
                        .HasColumnType("int");

                    b.Property<int?>("SecretariaID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("MedicoID");

                    b.HasIndex("PacienteID");

                    b.HasIndex("QuemCancelouID");

                    b.HasIndex("SecretariaID");

                    b.ToTable("TBAgendamentos");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Login", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("TBLogins");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Medico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("TBMedicos");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Paciente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("TBPaciente");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Secretaria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("TBSecretaria");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.TipoAcessos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("TBTipoAcessos");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TipoAcessoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipoAcessoID");

                    b.ToTable("TBUsuarios");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Agendamento", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoID");

                    b.HasOne("Projeto_Cliínica.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteID");

                    b.HasOne("Projeto_Cliínica.Models.Secretaria", "QuemCancelou")
                        .WithMany()
                        .HasForeignKey("QuemCancelouID");

                    b.HasOne("Projeto_Cliínica.Models.Secretaria", "Secretaria")
                        .WithMany()
                        .HasForeignKey("SecretariaID");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("QuemCancelou");

                    b.Navigation("Secretaria");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Login", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Medico", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Paciente", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Secretaria", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Cliínica.Models.Usuario", b =>
                {
                    b.HasOne("Projeto_Cliínica.Models.TipoAcessos", "TipoAcesso")
                        .WithMany()
                        .HasForeignKey("TipoAcessoID");

                    b.Navigation("TipoAcesso");
                });
#pragma warning restore 612, 618
        }
    }
}
