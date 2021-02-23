using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_api.Models
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext() {}
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
