// <auto-generated />
using System;
using Desafio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desafio.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Desafio.Model.Despesa", b =>
                {
                    b.Property<int>("idDespesa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("statusPagamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("tipoDespesa")
                        .HasColumnType("TEXT");

                    b.Property<int>("unidade")
                        .HasColumnType("INTEGER");

                    b.Property<float>("valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("vencimentoFatura")
                        .HasColumnType("TEXT");

                    b.HasKey("idDespesa");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Desafio.Model.Inquilino", b =>
                {
                    b.Property<int>("idInquilino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<int>("idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("sexo")
                        .HasColumnType("TEXT");

                    b.Property<int>("telefone")
                        .HasColumnType("INTEGER");

                    b.HasKey("idInquilino");

                    b.ToTable("Inquilinos");
                });

            modelBuilder.Entity("Desafio.Model.Unidade", b =>
                {
                    b.Property<int>("idUnidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("bairro")
                        .HasColumnType("TEXT");

                    b.Property<int>("cep")
                        .HasColumnType("INTEGER");

                    b.Property<string>("cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("condominio")
                        .HasColumnType("TEXT");

                    b.Property<string>("estado")
                        .HasColumnType("TEXT");

                    b.Property<int>("identificacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("proprietario")
                        .HasColumnType("TEXT");

                    b.Property<string>("rua")
                        .HasColumnType("TEXT");

                    b.HasKey("idUnidade");

                    b.ToTable("Unidades");
                });
#pragma warning restore 612, 618
        }
    }
}
