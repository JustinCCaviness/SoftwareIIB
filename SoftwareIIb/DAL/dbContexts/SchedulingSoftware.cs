using MySql.Data.EntityFramework;
using SoftwareIIb.DAL.Configurations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SoftwareIIb
{
    [DbConfigurationType(typeof(MySqlDataConfiguration))]
    public partial class SchedulingSoftware : DbContext
    {
        //public SchedulingSoftware()
        //    : base("name=SoftwareIIb.Properties.Settings.SchedulingSoftwareConnectionString")
        //{
        //}
        public SchedulingSoftware()
            : base("name=MySQL")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchedulingSoftware, Migrations.Configuration>());
        }
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<user> users { get; set; }

        public int SaveChanges<TEntity>() where TEntity : class
        {
            var original = this.ChangeTracker.Entries()
                        .Where(x => !typeof(TEntity).IsAssignableFrom(x.Entity.GetType()) && x.State != EntityState.Unchanged)
                        .GroupBy(x => x.State)
                        .ToList();

            foreach (var entry in this.ChangeTracker.Entries().Where(x => !typeof(TEntity).IsAssignableFrom(x.Entity.GetType())))
            {
                entry.State = EntityState.Unchanged;
            }

            var rows = base.SaveChanges();

            foreach (var state in original)
            {
                foreach (var entry in state)
                {
                    entry.State = state.Key;
                }
            }

            return rows;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<address>()
                .HasMany(e => e.customers)
                .WithRequired(e => e.address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.addresses)
                .WithRequired(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country>()
                .HasMany(e => e.cities)
                .WithRequired(e => e.country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

        }
    }
}
