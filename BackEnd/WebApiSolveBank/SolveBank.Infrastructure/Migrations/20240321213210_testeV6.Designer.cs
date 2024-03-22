﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolveBank.Infrastructure.Configuration;

#nullable disable

namespace SolveBank.Infrastructure.Migrations
{
    [DbContext(typeof(SolveBankDbConfig))]
    [Migration("20240321213210_testeV6")]
    partial class testeV6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Atendimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaResposta")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusAtendimento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContaID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Autenticacao2Fatores", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Utilizado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Autenticacao2Fatores");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContaBancariaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EnumBandeiraCartao")
                        .HasColumnType("int");

                    b.Property<int>("EnumCategoriaCartao")
                        .HasColumnType("int");

                    b.Property<int>("EnumTipoCartao")
                        .HasColumnType("int");

                    b.Property<decimal>("Limite")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LimiteUtilizado")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContaBancariaId");

                    b.HasIndex("ContaID");

                    b.ToTable("Cartoes");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.ContaBancaria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnumCategoriaConta")
                        .HasColumnType("int");

                    b.Property<string>("Informacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Limite")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LimiteUtilizado")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8)
                        .HasColumnType("int")
                        .IsFixedLength();

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<decimal>("Saldo")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Numero")
                        .IsUnique();

                    b.HasIndex("UsuarioID");

                    b.ToTable("ContasBancarias");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Mensagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AtendimentoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoID");

                    b.ToTable("Mensagens");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.SolveBankModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoDoBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SolveBank");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoDoBanco")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<Guid>("ContaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataTransacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaID");

                    b.ToTable("Transacoes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Transacao");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TransacaoCartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartaoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransacaoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartaoID");

                    b.HasIndex("TransacaoID");

                    b.ToTable("TransacoesCartoes");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CPF_CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("EnumTipoUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SolveBankModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CPF_CNPJ")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SolveBankModelId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SolveBank.Entities.Models.WebToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiracaoToken")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioID");

                    b.ToTable("WebTokens");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TDeposito", b =>
                {
                    b.HasBaseType("SolveBank.Entities.Models.Transacao");

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoDoEnvelope")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDaConta")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("TDeposito");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TPagamento", b =>
                {
                    b.HasBaseType("SolveBank.Entities.Models.Transacao");

                    b.Property<string>("Beneficiario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroBoleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Transacoes", t =>
                        {
                            t.Property("Beneficiario")
                                .HasColumnName("TPagamento_Beneficiario");
                        });

                    b.HasDiscriminator().HasValue("TPagamento");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TSaque", b =>
                {
                    b.HasBaseType("SolveBank.Entities.Models.Transacao");

                    b.Property<string>("LocalDoSaque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TSaque");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TTransferencia", b =>
                {
                    b.HasBaseType("SolveBank.Entities.Models.Transacao");

                    b.Property<string>("AgenciaDestino")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Beneficiario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaOrigem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroContaDestino")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasDiscriminator().HasValue("TTransferencia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SolveBank.Entities.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Atendimento", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.ContaBancaria", "ContaBancaria")
                        .WithMany("Atendimentos")
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ContaBancaria");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Autenticacao2Fatores", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Cartao", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.ContaBancaria", null)
                        .WithMany("Cartoes")
                        .HasForeignKey("ContaBancariaId");

                    b.HasOne("SolveBank.Entities.Models.ContaBancaria", "ContaBancaria")
                        .WithMany()
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ContaBancaria");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.ContaBancaria", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", "Usuario")
                        .WithMany("ContasBancarias")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Endereco", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Mensagem", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Atendimento", "Atendimento")
                        .WithMany("Mensagens")
                        .HasForeignKey("AtendimentoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Atendimento");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Transacao", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.ContaBancaria", "ContaBancaria")
                        .WithMany("Transacoes")
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ContaBancaria");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.TransacaoCartao", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Cartao", "Cartao")
                        .WithMany("TransacoesCartao")
                        .HasForeignKey("CartaoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SolveBank.Entities.Models.Transacao", "Transacao")
                        .WithMany()
                        .HasForeignKey("TransacaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cartao");

                    b.Navigation("Transacao");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Usuario", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.SolveBankModel", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("SolveBankModelId");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.WebToken", b =>
                {
                    b.HasOne("SolveBank.Entities.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Atendimento", b =>
                {
                    b.Navigation("Mensagens");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Cartao", b =>
                {
                    b.Navigation("TransacoesCartao");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.ContaBancaria", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Cartoes");

                    b.Navigation("Transacoes");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.SolveBankModel", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SolveBank.Entities.Models.Usuario", b =>
                {
                    b.Navigation("ContasBancarias");
                });
#pragma warning restore 612, 618
        }
    }
}
