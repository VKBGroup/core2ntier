using com.VKB.AutoInject.Locators;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    [EntityContext(name:"TempDB")]
    //[EntityContext(connection: @"Server=SQLServer;Database=TempDB;user=TempAdmin;password=t3mp@dm1n;")]
    public partial class DatabaseContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
            //empty to allow injecting options
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired();
            });
        }
    }
}
