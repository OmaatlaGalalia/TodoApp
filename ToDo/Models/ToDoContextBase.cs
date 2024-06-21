using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
    public class ToDoContextBase
    {

        //seed data

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work" },
                new Category { CategoryId = "home", Name = "Home" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                 new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "call", Name = "Contact" }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Open" },
                new Status { StatusId = "closed", Name = "Completed" }
                );
        }
    }
}