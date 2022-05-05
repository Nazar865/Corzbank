﻿// <auto-generated />
using System;
using Corzbank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Corzbank.Data.Migrations
{
    [DbContext(typeof(CorzbankDbContext))]
    [Migration("20220504152152_refactoredRelationships")]
    partial class refactoredRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Corzbank.Data.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<string>("CvvCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentSystem")
                        .HasColumnType("int");

                    b.Property<string>("SecretWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CardNumber")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("APY")
                        .HasColumnType("float");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.DepositCard", b =>
                {
                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("DepositId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("CardId", "DepositId");

                    b.HasIndex("DepositId");

                    b.ToTable("DepositCards");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Exchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BaseCurrency")
                        .HasColumnType("int");

                    b.Property<decimal>("Buy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ExchangeCurrency")
                        .HasColumnType("int");

                    b.Property<decimal>("Sell")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Exchanges");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSuccessful")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransferType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.TransferCard", b =>
                {
                    b.Property<int>("TransferId")
                        .HasColumnType("int");

                    b.Property<int>("SenderCardId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiverCardId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("TransferId", "SenderCardId", "ReceiverCardId");

                    b.HasIndex("ReceiverCardId");

                    b.HasIndex("SenderCardId");

                    b.ToTable("TransferCards");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Card", b =>
                {
                    b.HasOne("Corzbank.Data.Entities.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.DepositCard", b =>
                {
                    b.HasOne("Corzbank.Data.Entities.Card", "Card")
                        .WithMany("DepositCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Corzbank.Data.Entities.Deposit", "Deposit")
                        .WithMany("DepositCards")
                        .HasForeignKey("DepositId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Deposit");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.TransferCard", b =>
                {
                    b.HasOne("Corzbank.Data.Entities.Card", "ReceiverCard")
                        .WithMany("ReceiveTransfers")
                        .HasForeignKey("ReceiverCardId");

                    b.HasOne("Corzbank.Data.Entities.Card", "SenderCard")
                        .WithMany("SendTransfers")
                        .HasForeignKey("SenderCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Corzbank.Data.Entities.Transfer", "Transfer")
                        .WithMany("TransferCards")
                        .HasForeignKey("TransferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverCard");

                    b.Navigation("SenderCard");

                    b.Navigation("Transfer");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Card", b =>
                {
                    b.Navigation("DepositCards");

                    b.Navigation("ReceiveTransfers");

                    b.Navigation("SendTransfers");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Deposit", b =>
                {
                    b.Navigation("DepositCards");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.Transfer", b =>
                {
                    b.Navigation("TransferCards");
                });

            modelBuilder.Entity("Corzbank.Data.Entities.User", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
