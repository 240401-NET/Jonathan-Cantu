﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nparks.Data;

#nullable disable

namespace Nparks.Data.Migrations
{
    [DbContext(typeof(NparksDbContext))]
    partial class NparksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nparks.Models.BucketListParks", b =>
                {
                    b.Property<int>("bucket_id")
                        .HasColumnType("int");

                    b.Property<string>("bucket_list_item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nationalPark_id")
                        .HasColumnType("int");

                    b.Property<string>("special_notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.ToTable("BucketListParks");
                });

            modelBuilder.Entity("Nparks.Models.UserTable", b =>
                {
                    b.Property<string>("admin_privilege")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<string>("user_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_password")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTable");
                });

            modelBuilder.Entity("Nparks.Models.nationalParks", b =>
                {
                    b.Property<int>("nationalPark_id")
                        .HasColumnType("int");

                    b.Property<string>("nationalPark_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalPark_state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalPark_summary")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("nationalParks");
                });
#pragma warning restore 612, 618
        }
    }
}
