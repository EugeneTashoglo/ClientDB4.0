using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClientDB4._0
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<DocumentByService> DocumentByService { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServicePhoto> ServicePhoto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagOfClient> TagOfClient { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.GenderCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.PhotoClient)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientService)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.ClientID);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductPhoto)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductSale)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .Property(e => e.Discount)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ClientService)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.ServiceID);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Color)
                .IsFixedLength();

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.TagOfClient)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);
        }
    }
}
