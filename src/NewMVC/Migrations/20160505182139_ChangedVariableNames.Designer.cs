using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NewMVC.Models;

namespace NewMVC.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20160505182139_ChangedVariableNames")]
    partial class ChangedVariableNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewMVC.Models.Stop", b =>
                {
                    b.Property<int>("StopID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<int?>("TripTripID");

                    b.HasKey("StopID");
                });

            modelBuilder.Entity("NewMVC.Models.Trip", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.Property<string>("UserName");

                    b.HasKey("TripID");
                });

            modelBuilder.Entity("NewMVC.Models.Stop", b =>
                {
                    b.HasOne("NewMVC.Models.Trip")
                        .WithMany()
                        .HasForeignKey("TripTripID");
                });
        }
    }
}
