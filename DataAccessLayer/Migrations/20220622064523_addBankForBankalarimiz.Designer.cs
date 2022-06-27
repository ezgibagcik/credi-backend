﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220622064523_addBankForBankalarimiz")]
    partial class addBankForBankalarimiz
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtmSayisi")
                        .HasColumnType("int");

                    b.Property<string>("BankAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankCode")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EftHavale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubeSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("EntityLayer.Concrete.InterestRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<double>("InterestPercent")
                        .HasColumnType("float");

                    b.Property<int>("LoanTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MaxCreditCost")
                        .HasColumnType("int");

                    b.Property<int>("MaxTerm")
                        .HasColumnType("int");

                    b.Property<int>("MinCreditCost")
                        .HasColumnType("int");

                    b.Property<int>("MinTerm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("LoanTypeId");

                    b.ToTable("InterestRate");
                });

            modelBuilder.Entity("EntityLayer.Concrete.LoanType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoanCode")
                        .HasColumnType("int");

                    b.Property<string>("TypeAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoanType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PaymentPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AmountOfInterestPaid")
                        .HasColumnType("float");

                    b.Property<double>("AmountOfPrincipalPaid")
                        .HasColumnType("float");

                    b.Property<double>("InstallmentAmount")
                        .HasColumnType("float");

                    b.Property<double>("InterestRate")
                        .HasColumnType("float");

                    b.Property<int>("LoanTerm")
                        .HasColumnType("int");

                    b.Property<bool>("PaymentState")
                        .HasColumnType("bit");

                    b.Property<double>("RemainingPrincipalDebt")
                        .HasColumnType("float");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentPlan");
                });

            modelBuilder.Entity("EntityLayer.Concrete.InterestRate", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Bank", "Bank")
                        .WithMany("InterestRate")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.LoanType", "LoanType")
                        .WithMany("InterestRate")
                        .HasForeignKey("LoanTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("LoanType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bank", b =>
                {
                    b.Navigation("InterestRate");
                });

            modelBuilder.Entity("EntityLayer.Concrete.LoanType", b =>
                {
                    b.Navigation("InterestRate");
                });
#pragma warning restore 612, 618
        }
    }
}
