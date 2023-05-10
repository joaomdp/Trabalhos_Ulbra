namespace Data.Context
{
    public class MeuContexto : DbContext
    {
        protected string DbPath { get; }

        public MeuContexto()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "Aula12_PraticandoEmAula.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Pessoa> Pessoas {get; set;}
    }

    public class DbContext
    {
    }
}