using dt191g_moment32.Models;
using Microsoft.EntityFrameworkCore;

namespace dt191g_moment32.Data;

public class CollectionContext : DbContext
{
    public CollectionContext(DbContextOptions<CollectionContext> options) : base(options)
    {
    }

    public DbSet<Artist> Artist { get; set; }
    public DbSet<Cd> Cd { get; set; }
    public DbSet<Loan> Loan { get; set; }
}