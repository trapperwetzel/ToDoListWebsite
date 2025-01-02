
using Microsoft.EntityFrameworkCore;
namespace ToDoListWebApp.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ToDoListItem> ToDoListItems { get; set; }
        
        public ToDoListContext(DbContextOptions options) : base(options)
        {

        }


    }
}

