using InventoryClient.Configurations;
using Microsoft.EntityFrameworkCore;

namespace InventoryClient.Models
{
    public class UserContext : DbContext
    {
        #region Public Properties
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Data> Datas { get; set; }
        #endregion

        #region Overridde OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DataConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Override OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=127.0.0.1:5432;Database=InventoryClientDb;UserId=postgres;Password=admin");
        }
        #endregion
    }
}
