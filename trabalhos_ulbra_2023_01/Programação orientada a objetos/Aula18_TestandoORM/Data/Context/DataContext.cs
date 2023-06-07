using Aula12_TestandoORM.Domain;
using Aula12_TestandoORM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_test.Data
{
    public class DataContext : DbContext
    {
       public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEfSegunda.db");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}