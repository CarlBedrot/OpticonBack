﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpticonBackend.Data;

#nullable disable

namespace OpticonBackend.Migrations
{
    [DbContext(typeof(TopologiEditorContext))]
    [Migration("20240227131802_jsoning")]
    partial class jsoning
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("OpticonBackend.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComponentTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<string>("MeasurementUnit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeName");

                    b.ToTable("Components");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Component");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("OpticonBackend.Models.ComponentType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("BasedOn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("ComponentTypes");
                });

            modelBuilder.Entity("OpticonBackend.Models.Picture", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("OpticonBackend.Models.PictureAccess", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PictureId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("PictureAccesses");
                });

            modelBuilder.Entity("PicturePictureAccess", b =>
                {
                    b.Property<string>("PictureAccessesUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PicturesId")
                        .HasColumnType("TEXT");

                    b.HasKey("PictureAccessesUserId", "PicturesId");

                    b.HasIndex("PicturesId");

                    b.ToTable("PicturePictureAccess");
                });

            modelBuilder.Entity("OpticonBackend.Models.ProductionUnit", b =>
                {
                    b.HasBaseType("OpticonBackend.Models.Component");

                    b.Property<int>("AuxiliaryPowerAbs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuxiliaryPowerForm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AuxiliaryPowerRel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColdStartRamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("CoolingTimeHeat")
                        .HasColumnType("REAL");

                    b.Property<double>("CoolingTimeWarm")
                        .HasColumnType("REAL");

                    b.Property<string>("HeatStartRamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("LoadInterval")
                        .HasColumnType("REAL");

                    b.Property<int>("MaxLoadChangeSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MeasurePoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Performance")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PreparationTimeCold")
                        .HasColumnType("REAL");

                    b.Property<double>("PreparationTimeHeat")
                        .HasColumnType("REAL");

                    b.Property<double>("PreparationTimeWarm")
                        .HasColumnType("REAL");

                    b.Property<bool>("StartRamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("ProductionUnit");
                });

            modelBuilder.Entity("OpticonBackend.Models.Component", b =>
                {
                    b.HasOne("OpticonBackend.Models.ComponentType", "ComponentType")
                        .WithMany("Components")
                        .HasForeignKey("ComponentTypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComponentType");
                });

            modelBuilder.Entity("PicturePictureAccess", b =>
                {
                    b.HasOne("OpticonBackend.Models.PictureAccess", null)
                        .WithMany()
                        .HasForeignKey("PictureAccessesUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticonBackend.Models.Picture", null)
                        .WithMany()
                        .HasForeignKey("PicturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpticonBackend.Models.ComponentType", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
