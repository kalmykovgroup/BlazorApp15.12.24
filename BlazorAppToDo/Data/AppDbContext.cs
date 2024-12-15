using BlazorAppToDo.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDoList { get; set; }

     
        // Конструктор, принимающий DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
