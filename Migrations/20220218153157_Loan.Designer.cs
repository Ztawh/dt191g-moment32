﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dt191g_moment32.Data;

#nullable disable

namespace dt191g_moment32.Migrations
{
    [DbContext(typeof(CollectionContext))]
    [Migration("20220218153157_Loan")]
    partial class Loan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("dt191g_moment32.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Cd", b =>
                {
                    b.Property<int>("CdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Playtime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CdId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoanId");

                    b.HasIndex("CdId")
                        .IsUnique();

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Cd", b =>
                {
                    b.HasOne("dt191g_moment32.Models.Artist", "Artist")
                        .WithMany("Cds")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Loan", b =>
                {
                    b.HasOne("dt191g_moment32.Models.Cd", "Cd")
                        .WithOne("Loan")
                        .HasForeignKey("dt191g_moment32.Models.Loan", "CdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cd");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Artist", b =>
                {
                    b.Navigation("Cds");
                });

            modelBuilder.Entity("dt191g_moment32.Models.Cd", b =>
                {
                    b.Navigation("Loan");
                });
#pragma warning restore 612, 618
        }
    }
}
