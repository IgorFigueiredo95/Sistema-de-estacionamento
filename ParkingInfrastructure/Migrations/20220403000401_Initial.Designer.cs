// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingInfrastructure.Context;

namespace ParkingInfrastructure.Migrations
{
    [DbContext(typeof(ParkingDBContext))]
    [Migration("20220403000401_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingDomain.Entities.Operation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("HoursSpent")
                        .HasColumnType("time");

                    b.Property<Guid>("ParkingSpotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValuePaid")
                        .HasColumnType("decimal(4,2)");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParkingSpotId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("ParkingDomain.Entities.ParkingSpot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("VehicleSize")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParkingSpots");
                });

            modelBuilder.Entity("ParkingDomain.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Plate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("VehicleSize")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("ParkingDomain.Entities.Operation", b =>
                {
                    b.HasOne("ParkingDomain.Entities.ParkingSpot", null)
                        .WithMany("Operation")
                        .HasForeignKey("ParkingSpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingDomain.Entities.Vehicle", null)
                        .WithMany("Operation")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParkingDomain.Entities.ParkingSpot", b =>
                {
                    b.Navigation("Operation");
                });

            modelBuilder.Entity("ParkingDomain.Entities.Vehicle", b =>
                {
                    b.Navigation("Operation");
                });
#pragma warning restore 612, 618
        }
    }
}
