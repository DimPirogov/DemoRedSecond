﻿// <auto-generated />
using System;
using DemoAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230702182040_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DemoAPI.Conversation", b =>
                {
                    b.Property<int>("ConversationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConversationId"), 1L, 1);

                    b.Property<string>("ConversationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ListId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConversationId");

                    b.HasIndex("ListId");

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("DemoAPI.List", b =>
                {
                    b.Property<int>("ListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListId");

                    b.ToTable("Lists");

                    b.HasData(
                        new
                        {
                            ListId = 1,
                            Date = new DateTime(2014, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListName = "FirstList"
                        },
                        new
                        {
                            ListId = 2,
                            Date = new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListName = "SecondList"
                        });
                });

            modelBuilder.Entity("DemoAPI.Conversation", b =>
                {
                    b.HasOne("DemoAPI.List", "List")
                        .WithMany("Conversations")
                        .HasForeignKey("ListId");

                    b.Navigation("List");
                });

            modelBuilder.Entity("DemoAPI.List", b =>
                {
                    b.Navigation("Conversations");
                });
#pragma warning restore 612, 618
        }
    }
}
