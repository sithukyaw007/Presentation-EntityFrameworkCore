﻿// <auto-generated />
using System;
using EntityFramework.Demo.TphModel.CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Demo.TphModel.CodeFirst.Migrations
{
    [DbContext(typeof(TphDbContext))]
    partial class TphDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFramework.Demo.TphModel.CodeFirst.PersonTph", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PersonTph");
                });

            modelBuilder.Entity("EntityFramework.Demo.TphModel.CodeFirst.CustomerTph", b =>
                {
                    b.HasBaseType("EntityFramework.Demo.TphModel.CodeFirst.PersonTph");

                    b.Property<DateTime>("DateOfBirth");

                    b.ToTable("CustomerTph");

                    b.HasDiscriminator().HasValue("CustomerTph");
                });

            modelBuilder.Entity("EntityFramework.Demo.TphModel.CodeFirst.EmployeeTph", b =>
                {
                    b.HasBaseType("EntityFramework.Demo.TphModel.CodeFirst.PersonTph");

                    b.Property<decimal>("Turnover");

                    b.ToTable("EmployeeTph");

                    b.HasDiscriminator().HasValue("EmployeeTph");
                });
#pragma warning restore 612, 618
        }
    }
}
