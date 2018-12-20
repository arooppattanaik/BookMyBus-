﻿// <auto-generated />
using System;
using BookMyBus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMyBus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("BookMyBus.Models.BusRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusNumber");

                    b.Property<DateTime>("DateOfBooking");

                    b.Property<DateTime>("DateOfJounery");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("TotalNumberOfTickets");

                    b.HasKey("Id");

                    b.ToTable("BusRoutes");
                });

            modelBuilder.Entity("BookMyBus.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<char>("Gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PhoneNumber");

                    b.Property<int>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BookMyBus.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusRouteId");

                    b.Property<DateTime>("DateOfBooking");

                    b.Property<DateTime>("DateOfJounery");

                    b.Property<decimal>("Price");

                    b.Property<int>("SeatNumber");

                    b.HasKey("Id");

                    b.HasIndex("BusRouteId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("BookMyBus.Models.Customer", b =>
                {
                    b.HasOne("BookMyBus.Models.Ticket", "Ticket")
                        .WithOne("Customer")
                        .HasForeignKey("BookMyBus.Models.Customer", "TicketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookMyBus.Models.Ticket", b =>
                {
                    b.HasOne("BookMyBus.Models.BusRoute", "BusRoute")
                        .WithMany("Tickets")
                        .HasForeignKey("BusRouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
