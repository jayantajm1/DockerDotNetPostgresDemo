using DockerDotNetPostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerDotNetPostgresDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Weather> Weathers => Set<Weather>();
}
