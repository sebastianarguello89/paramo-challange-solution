﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sat.Recruitment.DataAccess;

namespace Sat.Recruitment.DataAccess.Migrations
{
    [DbContext(typeof(SatRecruitmentContext))]
    partial class SatRecruitmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sat.Recruitment.Model.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Sat.Recruitment.Model.NormalUser", b =>
                {
                    b.HasBaseType("Sat.Recruitment.Model.User");

                    b.HasDiscriminator().HasValue("NormalUser");
                });

            modelBuilder.Entity("Sat.Recruitment.Model.PremiumUser", b =>
                {
                    b.HasBaseType("Sat.Recruitment.Model.User");

                    b.HasDiscriminator().HasValue("PremiumUser");
                });

            modelBuilder.Entity("Sat.Recruitment.Model.SuperUser", b =>
                {
                    b.HasBaseType("Sat.Recruitment.Model.User");

                    b.HasDiscriminator().HasValue("SuperUser");
                });
#pragma warning restore 612, 618
        }
    }
}
