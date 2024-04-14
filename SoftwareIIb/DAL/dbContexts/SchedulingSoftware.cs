using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SoftwareIIb
{
    public partial class SchedulingSoftware : DbContext
    {
        //public SchedulingSoftware()
        //    : base("name=SoftwareIIb.Properties.Settings.SchedulingSoftwareConnectionString")
        //{
        //}
        public SchedulingSoftware()
            : base("name=MySQL")
        {
        }
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
