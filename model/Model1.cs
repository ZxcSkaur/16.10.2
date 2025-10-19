using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Mall> Mall { get; set; }
        public virtual DbSet<Pavilion> Pavilion { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Tenants> Tenants { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mall>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Pavilion)
                .WithRequired(e => e.Mall)
                .HasForeignKey(e => e.ID_mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Mall)
                .HasForeignKey(e => e.ID_Mall);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Pavilion1)
                .WithRequired(e => e.Mall1)
                .HasForeignKey(e => e.ID_mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Rent1)
                .WithOptional(e => e.Mall1)
                .HasForeignKey(e => e.ID_Mall);

            modelBuilder.Entity<Pavilion>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Pavilion)
                .HasForeignKey(e => new { e.Num_pav, e.ID_Mall });

            modelBuilder.Entity<Pavilion>()
                .HasMany(e => e.Rent1)
                .WithOptional(e => e.Pavilion1)
                .HasForeignKey(e => new { e.Num_pav, e.ID_Mall });

            modelBuilder.Entity<Tenants>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Tenants)
                .HasForeignKey(e => e.ID_tenan);

            modelBuilder.Entity<Tenants>()
                .HasMany(e => e.Rent1)
                .WithOptional(e => e.Tenants1)
                .HasForeignKey(e => e.ID_tenan);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_workers);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Rent1)
                .WithOptional(e => e.Workers1)
                .HasForeignKey(e => e.ID_workers);
        }
    }
}
