using Microsoft.EntityFrameworkCore;
using Safari.Data.Configuration;
using Safari.Data.Entities;

namespace Safari.Data.DbContext;

public class SafariDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    
    public SafariDbContext(DbContextOptions<SafariDbContext> options) : base(options)
    {
    }

    public DbSet<Martyr> Martyrs { get; set; }
    public DbSet<Comment> Comments { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new MartyrConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());

    }
}