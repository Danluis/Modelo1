using DANLUIS_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
namespace DANLUIS_AP1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Autor> Autorc { get; set; } = null!;
}
