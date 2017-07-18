using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SoruBankasi.Models.Db;

namespace SoruBankasi.Migrations
{
    [DbContext(typeof(PsbContext))]
    [Migration("20170718192711_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoruBankasi.Models.Db.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Definition");

                    b.Property<int>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SoruBankasi.Models.Db.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SoruBankasi.Models.Db.Question", b =>
                {
                    b.HasOne("SoruBankasi.Models.Db.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
