using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Pharmacy
{
    public partial class PharmacyBDContext : DbContext
    {
        public PharmacyBDContext()
        {
        }

        public PharmacyBDContext(DbContextOptions<PharmacyBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administration> Administration { get; set; }
        public virtual DbSet<CatalogMedication> CatalogMedication { get; set; }
        public virtual DbSet<Medication> Medication { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FAOMLAU\\SQLEXPRESS;Database=PharmacyBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administration>(entity =>
            {
                entity.HasKey(e => e.Idadministration)
                    .HasName("IDAdministration");

                entity.Property(e => e.Idadministration).HasColumnName("IDAdministration");

                entity.Property(e => e.LoginAdministration)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.PasswordAdministration)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<CatalogMedication>(entity =>
            {
                entity.HasKey(e => e.IdcatalogMedication)
                    .HasName("IDCatalogMedication");

                entity.Property(e => e.IdcatalogMedication).HasColumnName("IDCatalogMedication");

                entity.Property(e => e.Idmedication).HasColumnName("IDMedication");

                entity.HasOne(d => d.IdmedicationNavigation)
                    .WithMany(p => p.CatalogMedication)
                    .HasForeignKey(d => d.Idmedication)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_IDMedication");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.HasKey(e => e.Idmedication)
                    .HasName("IDMedication");

                entity.HasIndex(e => e.NameMedication)
                    .HasName("UQ_NameMedication")
                    .IsUnique();

                entity.Property(e => e.Idmedication).HasColumnName("IDMedication");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExperienceDate).HasColumnType("date");

                entity.Property(e => e.Idsuppliers).HasColumnName("IDSuppliers");

                entity.Property(e => e.NameMedication)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProductionDate).HasColumnType("date");

                entity.Property(e => e.WhithReceipt).HasMaxLength(10);

                entity.HasOne(d => d.IdsuppliersNavigation)
                    .WithMany(p => p.Medication)
                    .HasForeignKey(d => d.Idsuppliers)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_IDSuppliers");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.Idseller)
                    .HasName("IDSeller");

                entity.HasIndex(e => e.LoginSeller)
                    .HasName("UQ_LoginSeller")
                    .IsUnique();

                entity.Property(e => e.Idseller).HasColumnName("IDSeller");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LoginSeller)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.PasswordSeller)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.Idsuppliers)
                    .HasName("IDSuppliers");

                entity.HasIndex(e => e.NameSuppliers)
                    .HasName("UQ_NameSuppliers")
                    .IsUnique();

                entity.Property(e => e.Idsuppliers).HasColumnName("IDSuppliers");

                entity.Property(e => e.LoginSuppliers)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NameSuppliers)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PasswordSuppliers)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
