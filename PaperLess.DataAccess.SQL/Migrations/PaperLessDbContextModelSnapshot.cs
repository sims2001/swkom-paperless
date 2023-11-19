﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PaperLess.DataAccess.SQL;

#nullable disable

namespace PaperLess.DataAccess.SQL.Migrations
{
    [DbContext(typeof(PaperLessDbContext))]
    partial class PaperLessDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PaperLess.DataAccess.Entities.CorrespondentDAL", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("DocumentCount")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsInsensitive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastCorrespondence")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Match")
                        .HasColumnType("text");

                    b.Property<long>("MatchingAlgorithm")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Correspondents");
                });

            modelBuilder.Entity("PaperLess.DataAccess.Entities.DocumentDAL", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<DateTime>("Added")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ArchiveSerialNumber")
                        .HasColumnType("text");

                    b.Property<string>("ArchivedFileName")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int?>("Correspondent")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DocumentTypeDAL")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OriginalFileName")
                        .HasColumnType("text");

                    b.Property<int?>("StoragePath")
                        .HasColumnType("integer");

                    b.Property<List<int>>("Tags")
                        .HasColumnType("integer[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("PaperLess.DataAccess.Entities.DocumentTypeDAL", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("DocumentCount")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsInsensitive")
                        .HasColumnType("boolean");

                    b.Property<string>("Match")
                        .HasColumnType("text");

                    b.Property<long>("MatchingAlgorithm")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("PaperLess.DataAccess.Entities.TagDAL", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<long>("DocumentCount")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsInboxTag")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsInsensitive")
                        .HasColumnType("boolean");

                    b.Property<string>("Match")
                        .HasColumnType("text");

                    b.Property<long>("MatchingAlgorithm")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
