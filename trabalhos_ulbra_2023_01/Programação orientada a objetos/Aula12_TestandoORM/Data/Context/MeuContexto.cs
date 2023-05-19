using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aula12_TestandoORM.Data.Context
{
    public class MeuContexto : DbContext
    {
       protected string DbPath { get; }

        public MeuContexto()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestandoORM.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> Persons { get; set; }
        public DbSet<City> cities {get; set;}
    }
}