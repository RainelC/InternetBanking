
using InternetBanking.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetBanking.Infrastructure.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Beneficiary> beneficiaries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Tables

            modelBuilder.Entity<User>().ToTable("Usuarios");
            modelBuilder.Entity<Product>().ToTable("Productos");
            modelBuilder.Entity<Transaction>().ToTable("Transacciones");
            modelBuilder.Entity<Beneficiary>().ToTable("Beneficiarios");

            #endregion

            #region PrimaryKey

            modelBuilder.Entity<Beneficiary>().HasKey(b => b.Id);
            modelBuilder.Entity<Transaction>().HasKey(t => t.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.AccountID);
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            #endregion

            #region Relationships

            modelBuilder.Entity<User>()
                .HasMany<Product>(user => user.products)
                .WithOne(product => product.user)
                .HasForeignKey(product => product.userID)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
