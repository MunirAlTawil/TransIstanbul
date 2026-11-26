using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TransIstanbul.AddClasses
{
    public partial class BusAPPContext : DbContext
    {
        public BusAPPContext()
        {
        }

        public BusAPPContext(DbContextOptions<BusAPPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlueCard> BlueCards { get; set; }
        public virtual DbSet<ElectronicCard> ElectronicCards { get; set; }
        public virtual DbSet<IstanbulCard> IstanbulCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Connection string is read from the environment variable TRANSISTANBUL_DB.
                // Fallback: local SQL Server Express LocalDB for development.
                var connectionString = Environment.GetEnvironmentVariable("TRANSISTANBUL_DB")
                    ?? @"Server=(localdb)\MSSQLLocalDB;Database=TransIstanbul;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BlueCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("BlueCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<ElectronicCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("ElectronicCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();
            });

            modelBuilder.Entity<IstanbulCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("IstanbulCard");

                entity.Property(e => e.CardId).ValueGeneratedNever();

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
