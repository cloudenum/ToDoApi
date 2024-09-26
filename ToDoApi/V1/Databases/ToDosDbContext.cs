using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using ToDoApi.V1.Models;

namespace ToDoApi.V1.Databases
{
    public class ToDosDbContext(DbContextOptions<ToDosDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string hostName = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            string dbName = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "todo_db";
            string dbUser = Environment.GetEnvironmentVariable("DB_USERNAME") ?? "postgres";
            string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "";
            string connectionString = $"Host={hostName};Database={dbName};Username={dbUser};Password={dbPassword}";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
