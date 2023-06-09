﻿// <auto-generated />
using System;
using ICI.ProvaCandidato.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICI.ProvaCandidato.Web.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Texto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Noticia");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.NoticiaTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NoticiaId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NoticiaTag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoticiaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NoticiaId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Tag", b =>
                {
                    b.HasOne("ICI.ProvaCandidato.Dados.Noticia", null)
                        .WithMany("TagsSalvas")
                        .HasForeignKey("NoticiaId");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Noticia", b =>
                {
                    b.Navigation("TagsSalvas");
                });
#pragma warning restore 612, 618
        }
    }
}
