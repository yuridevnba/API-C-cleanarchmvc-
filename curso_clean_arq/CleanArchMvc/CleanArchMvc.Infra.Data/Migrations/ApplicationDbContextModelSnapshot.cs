﻿// <auto-generated />
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CleanArchMvc.Domain.Entities.Dados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("InicialMae")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("InicialPai")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Nascimento")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Dados");
                });

            modelBuilder.Entity("CleanArchMvc.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Ana@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Yuri@gmail.com"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Julio@gmail.com"
                        });
                });

            modelBuilder.Entity("CleanArchMvc.Domain.Entities.Dados", b =>
                {
                    b.HasOne("CleanArchMvc.Domain.Entities.Pessoa", "Pessoas")
                        .WithMany("Dados")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("CleanArchMvc.Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Dados");
                });
#pragma warning restore 612, 618
        }
    }
}
