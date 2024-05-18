using Microsoft.EntityFrameworkCore;
using Solid.Models;

namespace Solid.Data;

public class CompanyDbContext : DbContext
{
    public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
    {

    }

    //modelos
    public DbSet<Company> Companies { get; set; }
}