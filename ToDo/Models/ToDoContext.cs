using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add model configuration and seeding here if needed, for example:
            // modelBuilder.Entity<Category>().HasData(...);
            // modelBuilder.Entity<Status>().HasData(...);

            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = "work", Name = "Work" },
                 new Category { CategoryId = "home", Name = "Home" },
                 new Category { CategoryId = "ex", Name = "Exercise" },
                 new Category { CategoryId = "shop", Name = "Shopping" },
                 new Category { CategoryId = "call", Name = "Contact" }


                );
            modelBuilder.Entity<Status>().HasData(

                new Status { StatusId ="open", Name = "Open" },
                new Status { StatusId = "closed", Name = "completed"}

                );
        }
    }
}
