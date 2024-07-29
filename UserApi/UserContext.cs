using Microsoft.EntityFrameworkCore;

namespace UserApi
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            EnsureDatabaseCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Можно добавить конфигурации сущностей здесь, если нужно
        }

        public void EnsureDatabaseCreated()
        {
            this.Database.EnsureCreated(); // Или используйте this.Database.Migrate();
        }
    }
}
