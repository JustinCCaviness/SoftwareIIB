using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;
using System.Security.Policy;
using SoftwareIIb.Extensions;
using SoftwareIIb.DAL.Attributes;
using System.Data.Common;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SoftwareIIb
{
    //[DbConfigurationType(typeof(MySqlDataConfiguration))]
    public partial class SchedulingSoftware : DbContext
    {
        private readonly string _connectionString;
        //public SchedulingSoftware()
        //    : base("name=SoftwareIIb.Properties.Settings.SchedulingSoftwareConnectionString")
        //{
        //}

        public SchedulingSoftware(string connectionString) : base()
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL(_connectionString,
                    options => options.EnableRetryOnFailure()
                );

        }


        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<user> users { get; set; }

        public override int SaveChanges()
        {
            ChangeTracker.Entries<appointment>().Where(appt => appt.State != EntityState.Unchanged).ToList().ForEach(appt =>
            {
                appt.Entity.start = appt.Entity.start.SaveDateAsUtc();
                appt.Entity.end = appt.Entity.end.SaveDateAsUtc();
            });
            return base.SaveChanges();
        }

        public int SaveChanges<TEntity>() where TEntity : class
        {
            var original = ChangeTracker.Entries()
                        .Where(x => !typeof(TEntity).IsAssignableFrom(x.Entity.GetType()) && x.State != EntityState.Unchanged)
                        .GroupBy(x => x.State)
                        .ToList();

            foreach (var entry in this.ChangeTracker.Entries().Where(x => !typeof(TEntity).IsAssignableFrom(x.Entity.GetType())))
            {
                entry.State = EntityState.Unchanged;
            }

            var rows = SaveChanges();

            foreach (var state in original)
            {
                foreach (var entry in state)
                {
                    entry.State = state.Key;
                }
            }
            return rows;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<address>()
                .HasOne(e => e.city)
                .WithMany(c => c.addresses)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<city>()
                .HasOne(c => c.country)
                .WithMany(c => c.cities)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<country>()
                .HasMany(e => e.cities)
                .WithOne(e => e.country)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<customer>()
                .HasMany(c => c.appointments)
                .WithOne(a => a.customer)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<customer>()
                .HasOne(c => c.address)
                .WithMany(a => a.customers)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<user>()
                .HasMany(e => e.appointments)
                .WithOne(a => a.user)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<appointment>(entity =>
            {
                // for nullable column type
                //entity.Property(e => e.start).HasColumnType("datetime").HasConversion(x => x, y => DateTime.SpecifyKind(y.Value, DateTimeKind.Utc));
                entity
                    .Property(e => e.start)
                    .HasColumnType("datetime")
                    .HasConversion(
                        x => (x.Kind != DateTimeKind.Utc) ? x.ToUniversalTime() : x,
                        y => (y.Kind != DateTimeKind.Local) ? y.ToLocalTime() : y
                    );
                entity
                    .Property(e => e.end)
                    .HasColumnType("datetime")
                    .HasConversion(
                        x => (x.Kind != DateTimeKind.Utc) ? x.ToUniversalTime() : x,
                        y => (y.Kind != DateTimeKind.Local) ? y.ToLocalTime() : y
                        //x => x,
                        //y => DateTime.SpecifyKind(y, DateTimeKind.Utc)
                    );
            });
        }
    }
}
