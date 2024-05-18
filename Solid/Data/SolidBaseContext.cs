using Microsoft.EntityFrameworkCore;
using Solid.Models;

namespace Solid.Data;

public class SolidBaseContext : DbContext
{
    public SolidBaseContext(DbContextOptions<SolidBaseContext> options) : base(options)
    {

    }

    //modelos
    public DbSet<Companie> Companies { get; set; }
}