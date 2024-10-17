using Aluno2.Models;
using Microsoft.EntityFrameworkCore;


public class AppDataContext : DbContext
{
    public DbSet<Funcionario> funcionarios { get; set; }
    public DbSet<Folha> folhas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Aluno.db");
    }
}