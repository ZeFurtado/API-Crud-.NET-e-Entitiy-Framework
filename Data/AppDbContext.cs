using Microsoft.EntityFrameworkCore;

namespace ApiCrud;

public class AppDbContext : DbContext
{
        DbSet<Estudante> Estudantes {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite();
        base.OnConfiguring(optionsBuilder);
    }
}
