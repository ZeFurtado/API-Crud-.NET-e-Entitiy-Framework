using Microsoft.EntityFrameworkCore;

namespace ApiCrud;

public class AppDbContext : DbContext
{
        DbSet<Estudante> Estudantes {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
