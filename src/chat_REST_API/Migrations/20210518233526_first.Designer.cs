﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalR_chat_API.Data;

namespace SignalR_chat_API.Migrations
{
    [DbContext(typeof(databaseContext))]
    [Migration("20210518233526_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("chat_SignalR.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_Reciever")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_Sender")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("chat_SignalR.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FromId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("unread")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("chat_SignalR.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("metaMaskAddress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("privateKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
